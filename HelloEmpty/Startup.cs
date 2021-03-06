using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEmpty
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // MVC를 사용하겠다!
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // 웹 홈페이지에서 어떤 주소를 입력했을 때 어떤 애로 연결시켜줄 것인지를 정하는 곳
            app.UseEndpoints(endpoints =>
            {
            endpoints.MapControllerRoute(
                name: "default",

                // https://localhost:44320/Home/Index
                pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
