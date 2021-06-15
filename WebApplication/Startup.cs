 using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using DAL.Database;
using Logic.Interfaces;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
 using DAL.Interfaces;

 namespace WebApplication
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
            services.AddDbContext<MyContext>(Options => Options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddControllersWithViews();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme);
            
            //logic
            services.AddScoped<IProductLogic, ProductLogic>();
            services.AddScoped<IUserLogic, UserLogic>();
            //services.AddScoped<IInvoiceLogic,>

            //dal
            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<IUserDal, UserDAL>();

            //database
            services.AddScoped<IMyContext, MyContext>();
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
