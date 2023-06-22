using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerSpaces
{
    [Description("")]
    Default,
    [Description("space")]
    Space,
    [Description("no-space")]
    NoSpace,
    [Description("small-space")]
    SmallSpace,
    [Description("medium-space")]
    MediumSpace,
    [Description("large-space")]
    LargeSpace
}
