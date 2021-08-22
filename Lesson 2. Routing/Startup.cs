using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_2._Routing
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name: "TwoParameterRoute",
                    pattern: "{controller}/{action}/{x}/{y}"
                    );

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=index}"
                    );
            });
        }
    }
}
