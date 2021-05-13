using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Data.Interfaces;
using Shop.Data.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
            services.AddMvc(option => option.EnableEndpointRouting = false);

          //  services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();//vivod Oshibok
            app.UseStatusCodePages();//codi stranic 200 ili 404 i drugie
            app.UseStaticFiles();//dla podklucheniya failov kartinok i drugih
           //   app.UseMvcWithDefaultRoute();//stranica po umolchaniyu


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //++++++++++++++++++=
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=название контроллера}/{action=название действия контроллера}");
            });

            app.UseMvcWithDefaultRoute();
            //---------------

  //          app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                                // await context.Response.WriteAsync("Hello World!");
                                await context.Response.WriteAsync("Hello World!");
                });
            });

            //+++++++++++++++
            /*
                        app.UseMvc(routes =>
                        {
                            routes.MapRoute("api/get", async context =>
                            {
                                await context.Response.WriteAsync("для обработки использован маршрут api/get");
                            });

                            routes.MapRoute(
                                name: "default",
                                template: "{controller=Home}/{action=Index}/{id?}");
                        });
            */
            //-----------------
        }
    }
}
