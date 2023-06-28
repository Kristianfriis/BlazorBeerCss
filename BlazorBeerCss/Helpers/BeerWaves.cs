using System.ComponentModel;

namespace BlazorBeerCss;

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
