using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerThemes
{
    [Description("")]
    Default,
    [Description("light")]
    Light,
    [Description("dark")]
    Dark,
    [Description("transparent")]
    Transparent
}
