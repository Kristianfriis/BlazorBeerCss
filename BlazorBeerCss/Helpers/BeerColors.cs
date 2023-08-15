using System.ComponentModel;

namespace BlazorBeerCss;

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
    TertiaryContainer,
    [Description("pink")]
    Pink,
    [Description("orange")]
    Orange,
    [Description("yellow")]
    Yellow
}
