using BlazorProductStore.Server.Models;
using BlazorProductStore.Shared.Models;
using BlazorProductStore.Shared.ViewModels;
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
    public class HomeController : ControllerBase
    {
        private readonly TestProductDbContext _context;
        private readonly ILogger<HomeController> _logger;
        public HomeController(TestProductDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _context.Products.ToListAsync();
                _logger.LogWarning("GOT PRODUCT " + products.Count.ToString());
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CompleteOrder([FromBody] CompletedOrder order)
        {
            try
            {
                var orders = new Order()
                {
                    AddressLine1 = order.AddressLine1,
                    AddressLine2 = order.AddressLine2,
                    City = order.City,
                    Country = order.Country,
                    GiftWrap = order.GiftWrap == true ? (sbyte)1 : (sbyte)0,
                    Name = order.Name,
                    State = order.State,
                    Zip = order.Zip,
                    Shipped = order.Shipped == true ? (sbyte)1 : (sbyte)0
                };
                await _context.Orders.AddAsync(orders);
                await _context.SaveChangesAsync();

                orders = _context.Orders.OrderByDescending(x => x.Id).FirstOrDefault();

                foreach (var cartline in order.CartLineVMs)
                {
                    await _context.Cartlines.AddAsync(new Cartline()
                    {
                        OrderId = orders.Id,
                        ProductId = cartline.ProductId,
                        Quantity = cartline.Quantity
                    });
                }

                await _context.SaveChangesAsync();

                _logger.LogWarning("Order saved");

                return Ok("Your order successfully registered!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }
    }
}
