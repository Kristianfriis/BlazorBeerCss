using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

public enum BeerForms
{
    [Description("")]
    Default,
    [Description("fill")]
    Fill,
    [Description("border")]
    Border,
    [Description("circle")]
    Circle,
    [Description("square")]
    Square,
    [Description("round")]
    Round,
    [Description("no-round")]
    NoRound,
    [Description("left-round")]
    LeftRound,
    [Description("right-round")]
    RightRound,
    [Description("top-round")]
    TopRound,
    [Description("bottom-round")]
    BottomRound,
    [Description("responsive")]
    Responsive,
    [Description("none")]
    None,
    [Description("extend")]
    Extend
}
