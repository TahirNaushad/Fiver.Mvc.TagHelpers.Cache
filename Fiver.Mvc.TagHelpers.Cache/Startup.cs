using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Fiver.Mvc.TagHelpers.Cache
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = "...";
            });

            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}
