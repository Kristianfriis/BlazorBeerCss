using System.ComponentModel;

namespace BlazorBeerCss;

public enum BeerPaddings
{
    [Description("")]
    Default,
    [Description("padding")]
    Padding,
    [Description("no-padding")]
    NoPadding,
    [Description("tiny-padding")]
    TinyPadding,
    [Description("small-padding")]
    SmallPadding,
    [Description("medium-padding")]
    MediumPadding,
    [Description("large-padding")]
    LargePadding
}
