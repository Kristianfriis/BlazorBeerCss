using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

public enum BeerWaves
{
    [Description("")]
    Default,
    [Description("wave")]
    Wave,
    [Description("no-wave")]
    NoWave,
    [Description("light")]
    Light,
    [Description("dark")]
    Dark
}
