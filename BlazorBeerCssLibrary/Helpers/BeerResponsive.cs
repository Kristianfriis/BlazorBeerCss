using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerResponsive
{
    [Description("")]
    Default,
    [Description("responsive")]
    Responsive,
    [Description("s")]
    Small,
    [Description("m")]
    Medium,
    [Description("l")]
    Large
}
