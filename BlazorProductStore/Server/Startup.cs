using BlazorProductStore.Server.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace BlazorProductStore.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("MySqlDb");
            var identityConnection = Configuration.GetConnectionString("MyIdentityDb");

            services.AddDbContext<TestProductDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseMySql(identityConnection, ServerVersion.AutoDetect(identityConnection)));

            services.Configure<IdentityOptions>(config =>
            {
                config.Password.RequireDigit = true;
                config.Password.RequiredLength = 8;
                config.Password.RequireUppercase = true;
                config.Password.RequireNonAlphanumeric = false;
            });

            services.AddAuthentication(optios =>
            {
                optios.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                optios.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                optios.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                optios.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                optios.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
                optios.RequireAuthenticatedSignIn = false;

            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                //options.RequireHttpsMetadata = false;


                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["jwtSecret"])),
                    ValidateAudience = false,
                    ValidateIssuer = false
                };
                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = async ctx =>
                    {
                        var usrmgr = ctx.HttpContext.RequestServices.GetRequiredService<UserManager<IdentityUser>>();
                        var signinmgr = ctx.HttpContext.RequestServices.GetRequiredService<SignInManager<IdentityUser>>();
                        string username = ctx.Principal.FindFirst(ClaimTypes.Name)?.Value;
                        IdentityUser idUser = await usrmgr.FindByNameAsync(username);
                        ctx.Principal = await signinmgr.CreateUserPrincipalAsync(idUser);
                    }
                };
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                 .AddEntityFrameworkStores<AppIdentityDbContext>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });

            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
