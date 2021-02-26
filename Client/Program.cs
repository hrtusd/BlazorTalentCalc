using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorTalentCalc.Client.Shared;
using BlazorTalentCalc.Shared.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTalentCalc.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<AppState>();

            builder.Services.AddTransient<ClassService>();

            await builder.Build().RunAsync();
        }
    }
}