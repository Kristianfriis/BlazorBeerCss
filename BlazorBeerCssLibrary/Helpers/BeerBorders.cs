using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

public enum BeerBorders
{
    [Description("")]
    Default,
    [Description("border")]
    Border,
    [Description("round")]
    Round,
    [Description("no-round")]
    NoRound,
    [Description("left-round")]
    LeftRound,
    [Description("top-round")]
    TopRound,
    [Description("right-round")]
    RightRound,
    [Description("bottom-round")]
    BottomRound
}
