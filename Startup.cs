using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BioLister
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddMvcCore()
                    .AddJsonFormatters();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Debug);

            app.UseMvc();
        }
    }
}