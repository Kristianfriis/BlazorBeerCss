using BlazorBeerCss;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBeerCss;

public static class BuilderExtensions
{
    public static void AddBlazorBeerCss(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddSingleton<BeerThemeChanger>();
    }
}
