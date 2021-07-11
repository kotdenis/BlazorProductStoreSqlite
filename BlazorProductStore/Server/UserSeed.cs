using BlazorProductStore.Server.Models;
using BlazorProductStore.Server.Services;
using BlazorProductStore.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProductStore.Server
{
    public class UserSeed
    {
        private readonly IUserService _userService;
        public UserSeed(IUserService userService)
        {
            _userService = userService;
        }
        public void EnsurePopulated()
        {
            var user = new User()
            {
                Username = "Admin"
            };

            var password = "Secret123$";

            _userService.Create(user, password);
        }
    }
}
