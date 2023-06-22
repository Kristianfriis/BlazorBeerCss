using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerColors
{
    [Description("")]
    Default,
    [Description("fill")]
    Fill,
    [Description("primary")]
    Primary,
    [Description("secondary")]
    Secondary,
    [Description("tertiary")]
    Tertiary,
    [Description("primary-container")]
    PrimaryContainer,
    [Description("secondary-container")]
    SecondaryContainer,
    [Description("tertiary-container")]
    TertiaryContainer
}
