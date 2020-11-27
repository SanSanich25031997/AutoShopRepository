using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DataLayer.Repository;
using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer;
using AutoShop.ViewModels.OrderVM;
using AutoShop.ViewModels.ModelStateVM;

namespace AutoShop
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AutoShopDbContext>(options => options.UseSqlServer(configuration
                .GetConnectionString("DefaultConnection")));
            services.AddScoped<IModelStateViewModelBuilder, ModelStateViewModelBuilder>();
            services.AddScoped<IOrderFormValidator, OrderFormValidator>();
            services.AddScoped<IOrderFormHandler, OrderFormHandler>();
            services.AddTransient<ICarsRepository, CarsRepository>();
            services.AddTransient<ICarCategoriesRepository, CategoriesRepository>();
            services.AddTransient<IOrdersRepository, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => AutoShopCart.GetCart(sp));

            services.AddHttpClient();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews(mvcOptions =>
            {
                mvcOptions.EnableEndpointRouting = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{Id?}");
                routes.MapRoute(name: "categoryFilter", template: "Cars/{action}/{category?}", 
                    defaults: new { Controller = "Car", action = "List" });
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AutoShopDbContext context = scope.ServiceProvider.GetRequiredService<AutoShopDbContext>();
                DbObjects.Initial(context);
            }
        }
    }
}
