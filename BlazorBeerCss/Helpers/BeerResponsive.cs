using System.ComponentModel;

namespace BlazorBeerCss;

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
