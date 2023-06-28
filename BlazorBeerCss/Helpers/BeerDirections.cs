using System.ComponentModel;

namespace BlazorBeerCss;

public enum BeerDirections
{
    [Description("")]
    Default,
    [Description("horizontal")]
    Horizontal,
    [Description("vertical")]
    Vertical
}
