using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

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
    Extra
}
