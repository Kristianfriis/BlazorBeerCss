using System.ComponentModel;

namespace BlazorBeerCss;

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
