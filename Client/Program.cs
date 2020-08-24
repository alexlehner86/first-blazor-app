using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using firstBlazorApp.Client.Helpers;

namespace firstBlazorApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); // Authorization System
            services.AddSingleton<IRepository, RepositoryInMemory>();
            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientService>();
        }
    }
}
