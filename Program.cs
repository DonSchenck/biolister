using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BioLister
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>().UseUrls("http://*:8080")
                .Build();

            host.Run();
        }
    }
}
