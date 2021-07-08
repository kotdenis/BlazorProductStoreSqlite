using BlazorProductStore.Shared.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProductStore.Server.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<IdentityUser> _signinManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        public AccountController(ILogger<AccountController> logger, SignInManager<IdentityUser> signinManager,
            UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _logger = logger;
            _signinManager = signinManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            try
            {
                _logger.LogWarning("Try log");
                var user = await _userManager.FindByNameAsync(loginModel.UserName);
                if (user == null)
                    return Unauthorized();
                var signResult = await _signinManager.CheckPasswordSignInAsync(user, loginModel.Password, false);

                if (signResult.Succeeded)
                {
                    await _signinManager.SignInAsync(user, false);

                    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                    byte[] secret = Encoding.ASCII.GetBytes(_configuration["jwtSecret"]);

                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Name, loginModel.UserName)
                    };

                    SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(claims),
                        Expires = DateTime.UtcNow.AddHours(24),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
                    };

                    SecurityToken token = handler.CreateToken(descriptor);

                    _logger.LogWarning("Log in");

                    return Ok(new UserModel
                    {
                        UserName = loginModel.UserName,
                        Token = handler.WriteToken(token)
                    });
                }
                else
                    return Unauthorized();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public CurrentUser GetCurrentUser()
        {
            try
            {
                var temp = User.Claims;
                var mop = User.Identity.IsAuthenticated;

                return new CurrentUser
                {
                    IsAuthenticated = User.Identity.IsAuthenticated,
                    UserName = User.Identity.Name,
                    Claims = User.Claims
                        .ToDictionary(c => c.Type, c => c.Value)
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new CurrentUser();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return Ok();
        }
    }
}
