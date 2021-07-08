using BlazorProductStore.Shared.Constants;
using BlazorProductStore.Shared.Models;
using BlazorProductStore.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorProductStore.Client.Services
{
    public interface IAdminService
    {
        Task<List<CompletedOrder>> GetAllOrdersAsync();
        Task<HttpResponseMessage> UpdateOrderAsync(CompletedOrder completedOrder);
        Task<HttpResponseMessage> EditProductAsync(Product product);
        Task<HttpResponseMessage> CreateProductAsync(Product product);
        Task<HttpResponseMessage> DeleteProductAsync(Product product);
    }
    public class AdminService : IAdminService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public AdminService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public async Task<List<CompletedOrder>> GetAllOrdersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<CompletedOrder>>(new Uri(AppConstant.Uri + "Admin/GetAllOrders"));
            }
            catch (Exception)
            {
                return new List<CompletedOrder>();
            }
        }

        public async Task<HttpResponseMessage> UpdateOrderAsync(CompletedOrder completedOrder)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/UpdateOrder"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(completedOrder)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public async Task<HttpResponseMessage> EditProductAsync(Product product)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/EditProduct"),
                    Method = HttpMethod.Put,
                    Content = JsonContent.Create(product)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public async Task<HttpResponseMessage> CreateProductAsync(Product product)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/CreateProduct"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(product)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public async Task<HttpResponseMessage> DeleteProductAsync(Product product)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/DeleteProduct"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(product)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
