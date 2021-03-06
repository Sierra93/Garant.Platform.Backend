using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore;

namespace Garant.Platform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://*:9991")
                .UseStartup<Startup>();
    }
}