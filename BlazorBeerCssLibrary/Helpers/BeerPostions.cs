using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerPostions
{
    [Description("")]
    Default,
    [Description("left")]
    Left,
    [Description("right")]
    Right,
    [Description("top")]
    Top,
    [Description("bottom")]
    Bottom
}
