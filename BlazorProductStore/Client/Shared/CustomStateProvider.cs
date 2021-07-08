﻿using BlazorProductStore.Client.Services;
using BlazorProductStore.Shared.Constants;
using BlazorProductStore.Shared.IdentityModels;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorProductStore.Client.Shared
{
    public class CustomStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IAuthorizeService _authorizeService;
        private CurrentUser _currentUser;
        public CustomStateProvider(ILocalStorageService localStorage, IAuthorizeService authorizeService)
        {
            _localStorage = localStorage;
            _authorizeService = authorizeService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            var userInfo = await GetCurrentUser();
            if (userInfo.IsAuthenticated)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, _currentUser.UserName)
                }.Concat(_currentUser.Claims.Select(x => new Claim(x.Key, x.Value)));

                identity = new ClaimsIdentity(claims, "Server authentication");
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        private async Task<CurrentUser> GetCurrentUser()
        {
            if (_currentUser != null && _currentUser.IsAuthenticated)
                return _currentUser;
            else
                _currentUser = await _authorizeService.GetCurrentUser();
            return _currentUser;
        }

        public async Task<bool> Login(LoginModel loginModel)
        {
            try
            {
                var response = await _authorizeService.Login(loginModel);
                if (response.IsSuccessStatusCode)
                {
                    NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                    var userModel = await response.Content.ReadFromJsonAsync<UserModel>();
                    await _localStorage.SetItem<string>(AppConstant.Token, userModel.Token);
                    await _localStorage.SetItem<string>(AppConstant.UserName, userModel.UserName);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task Logout()
        {
            await _authorizeService.Logout();
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            await _localStorage.RemoveItem(AppConstant.Token);
            await _localStorage.RemoveItem(AppConstant.UserName);
        }
    }
}
