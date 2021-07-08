using BlazorProductStore.Server.Models;
using BlazorProductStore.Shared.Models;
using BlazorProductStore.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProductStore.Server.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Identity.Application, Bearer")]
    public class AdminController : ControllerBase
    {
        private readonly TestProductDbContext _context;
        private readonly ILogger<AdminController> _logger;
        public AdminController(TestProductDbContext context, ILogger<AdminController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                List<CompletedOrder> completedOrders = new List<CompletedOrder>();
                List<CartLineVM> cartLineVMs;
                var orders = await _context.Orders.ToListAsync();

                foreach(var o in orders)
                {
                    cartLineVMs = new List<CartLineVM>();
                    foreach (var p in _context.Cartlines.Where(x => x.OrderId == o.Id).ToList())
                    {
                        var product = _context.Products.Where(x => x.Id == p.ProductId).FirstOrDefault();
                        cartLineVMs.Add(new CartLineVM()
                        {
                            Name = product.Name,
                            Quantity = p.Quantity,
                            Price = product.Price,
                            ProductId = product.Id
                        });
                    }

                    completedOrders.Add(new CompletedOrder()
                    {
                        AddressLine1 = o.AddressLine1,
                        AddressLine2 = o.AddressLine2,
                        CartLineVMs = cartLineVMs,
                        City = o.City,
                        Country = o.Country,
                        GiftWrap = o.GiftWrap == 0 ? false : true,
                        Shipped = o.Shipped == 0 ? false : true,
                        Name = o.Name,
                        State = o.State,
                        Zip = o.Zip,
                        OrderId = o.Id
                    });
                }
                _logger.LogWarning("Got orders");
                return Ok(completedOrders);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrder([FromBody] CompletedOrder completedOrder)
        {
            try
            {
                var order = _context.Orders.Where(x => x.Id == completedOrder.OrderId).FirstOrDefault();
                order.Shipped = completedOrder.Shipped == true ? (sbyte)1 : (sbyte)0;
                _context.Entry(order).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok("The order was shipped");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error!");
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct([FromBody] Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok("Current product was modified!");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();

                return Ok("Product was successfully created!");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct([FromBody] Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Deleted;
                await _context.SaveChangesAsync();

                return Ok("Product was successfully deleted!");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error!");
            }
        }
    }
}
