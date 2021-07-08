using BlazorProductStore.Shared.Constants;
using BlazorProductStore.Shared.Models;
using BlazorProductStore.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorProductStore.Client.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<HttpResponseMessage> CompleteOrder(CompletedOrder order);
    }
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Product>>(new Uri(AppConstant.Uri + "Home/GetAllProducts"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Product>();
            }
        }

        public async Task<HttpResponseMessage> CompleteOrder(CompletedOrder order)
        {
            try
            {
                Console.WriteLine("Complete order");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Home/CompleteOrder"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(order)
                };
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch(Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        
    }
}
