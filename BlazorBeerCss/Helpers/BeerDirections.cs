using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerDirections
{
    [Description("")]
    Default,
    [Description("horizontal")]
    Horizontal,
    [Description("vertical")]
    Vertical
}
