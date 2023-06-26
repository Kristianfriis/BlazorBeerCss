using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerSizes
{
    [Description("")]
    Default,
    [Description("tiny")]
    Tiny,
    [Description("small")]
    Small,
    [Description("medium")]
    Medium,
    [Description("large")]
    Large,
    [Description("extra")]
    Extra,
    [Description("wrap")]
    Wrap,
    [Description("no-wrap")]
    NoWrap,
    [Description("max")]
    Max,    
    [Description("min")]
    Minimum,
    [Description("small-width")]
    SmallWidth,
    [Description("medium-width")]
    MediumWidth,
    [Description("large-width")]
    LargeWidth,
    [Description("small-height")]
    SmallHeight,
    [Description("medium-height")]
    MediumHeight,
    [Description("large-height")]
    LargeHeight
}
