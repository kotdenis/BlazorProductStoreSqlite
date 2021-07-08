using BlazorProductStore.Shared.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorProductStore.Client.Services
{
    public interface IAuthorizeService
    {
        Task<HttpResponseMessage> Login(LoginModel loginModel);
        Task<CurrentUser> GetCurrentUser();
        Task Logout();
    }
    public class AuthorizeService : IAuthorizeService
    {
        private readonly HttpClient _httpClient;
        public AuthorizeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> Login(LoginModel loginModel)
        {
            var result = await _httpClient.PostAsJsonAsync("Account/Login", loginModel);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();

            return result;
        }

        public async Task<CurrentUser> GetCurrentUser()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<CurrentUser>("Account/GetCurrentUser");
            }
            catch (Exception ex)
            {
                return new CurrentUser();
            }
        }

        public async Task Logout()
        {
            await _httpClient.PostAsJsonAsync("Account/Logout", new UserModel());
        }
    }
}
