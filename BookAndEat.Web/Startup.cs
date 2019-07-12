using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookAndEat.Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using BookAndEat.Services;
using BookAndEat.DataAccess;
using BookAndEat.DataModels;
using BookAndEat.DataAccess.Identity;
using BookAndEat.Common;

namespace BookAndEat.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IDishService, DishService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            //services.AddDbContext<ApplicationDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedDatabase(app);
        }

        private static void SeedDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                      .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }

        private static void SeedRoles(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                      .CreateScope())
            {
                using (var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>())
                using (var userManager = serviceScope.ServiceProvider.GetService<UserManager<AppUser>>())
                using (var userStore = serviceScope.ServiceProvider.GetService<AppUserStore>())
                {
                    bool userRoleExists = roleManager.RoleExistsAsync(AppRoles.AppAdmin)
                        .GetAwaiter()
                        .GetResult();
                    if (!userRoleExists)
                    {
                        var role = new IdentityRole();
                        role.Name = AppRoles.AppAdmin;
                        roleManager.CreateAsync(role).GetAwaiter().GetResult();
                    }

                    userRoleExists = roleManager.RoleExistsAsync(AppRoles.Admin)
                        .GetAwaiter()
                        .GetResult();
                    if (!userRoleExists)
                    {
                        var role = new IdentityRole();
                        role.Name = AppRoles.Admin;
                        roleManager.CreateAsync(role).GetAwaiter().GetResult();
                    }

                    userRoleExists = roleManager.RoleExistsAsync(AppRoles.Manager)
                        .GetAwaiter()
                        .GetResult();
                    if (!userRoleExists)
                    {
                        var role = new IdentityRole();
                        role.Name = AppRoles.Manager;
                        roleManager.CreateAsync(role).GetAwaiter().GetResult();
                    }

                    userRoleExists = roleManager.RoleExistsAsync(AppRoles.Waiter)
                        .GetAwaiter()
                        .GetResult();
                    if (!userRoleExists)
                    {
                        var role = new IdentityRole();
                        role.Name = AppRoles.Waiter;
                        roleManager.CreateAsync(role).GetAwaiter().GetResult();
                    }

                    userRoleExists = roleManager.RoleExistsAsync(AppRoles.User)
                        .GetAwaiter()
                        .GetResult();
                    if (!userRoleExists)
                    {
                        var role = new IdentityRole();
                        role.Name = AppRoles.User;
                        roleManager.CreateAsync(role).GetAwaiter().GetResult();
                    }

                    AppUser appUser = userManager.FindByNameAsync("adminUser").GetAwaiter().GetResult();
                    if (appUser == null)
                    {
                        appUser = new AppUser();
                        appUser.DateOfBirth = new DateTime(1997, 12, 07);
                        appUser.Email = "herbutkatia@gmail.com";
                        appUser.EmailConfirmed = true;
                        appUser.FirstName = "Admin";
                        appUser.LastName = "Admin";
                        appUser.PhoneNumber = "380997028035";
                        appUser.PhoneNumberConfirmed = true;

                        userManager.CreateAsync(appUser).GetAwaiter().GetResult();
                    }

                    userStore.AddToRoleAsync(appUser, null, AppRoles.AppAdmin);
                }
            }
        }
    }
}
