using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

public enum BeerDirections
{
    [Description("")]
    Default,
    [Description("horizontal")]
    Horizontal,
    [Description("vertical")]
    Vertical
}
