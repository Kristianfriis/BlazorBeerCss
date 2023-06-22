using Microsoft.JSInterop;

namespace BlazorBeerCss;

public class BeerThemeChanger
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;
    public BeerThemeChanger(IJSRuntime jSRuntime)
    {
        moduleTask = new(() => jSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BlazorBeerCss/js/interop.js?3").AsTask());
    }

    public async Task SetDarkMode(bool darkMode)
    {
        var module = await moduleTask.Value;
        if (darkMode)
            await module.InvokeVoidAsync("setDarkMode");
        else
            await module.InvokeVoidAsync("setLightMode");
    }
}
