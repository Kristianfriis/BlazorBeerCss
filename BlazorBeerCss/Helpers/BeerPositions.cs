using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerPositions
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
