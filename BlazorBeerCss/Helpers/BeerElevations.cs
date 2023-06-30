using System.ComponentModel;

namespace BlazorBeerCss;

public enum BeerElevations
{
    [Description("")]
    Default,
    [Description("large-elevate")]
    Large,
    [Description("medium-elevate")]
    Medium,
    [Description("small-elevate")]
    Small,
    [Description("")]
    None,
}
