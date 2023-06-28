using System.ComponentModel;

namespace BlazorBeerCss;

public enum BeerAlignments
{
    [Description("")]
    Default,
    [Description("left-align")]
    LeftAlign,
    [Description("right-align")]
    RightAlign,
    [Description("center-align")]
    CenterAlign,
    [Description("top-align")]
    TopAlign,
    [Description("bottom-align")]
    BottomAlign,
    [Description("middle-align")]
    MiddleAlign
}
