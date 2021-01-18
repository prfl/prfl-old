using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Profile.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Http;

namespace Profile
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<StateContainer>();
            builder.Services.AddSingleton<VisitorState>();

            builder.Services.AddBlazoredLocalStorage();

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://prfl.azurewebsites.net") });

            await builder.Build().RunAsync();
        }
    }
}
