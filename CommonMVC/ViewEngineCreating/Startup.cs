using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using ViewEngineCreating.Utils;

namespace ViewEngineCreating
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.Configure<MvcViewOptions>(options =>
            {
                options.ViewEngines.Clear();
                options.ViewEngines.Insert(0, new CustomViewEngine());

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();

            //}
            app.UseMvc(routes =>
                {
                    routes.MapRoute("api", "api/get", new { controller = "Home", action = "About" });

                    routes.MapRoute("another/get", async context=>
                        {
                            await context.Response.WriteAsync("another/get route was used for handling");

                        });

                    routes.MapRoute(name:"default",template: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        
          
        }
    }

