using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

public enum BeerTexts
{
    [Description("")]
    Default,
    [Description("italic")]
    Italic,
    [Description("bold")]
    Bold,
    [Description("underline")]
    Underline,
    [Description("overline")]
    Overline,
    [Description("upper")]
    Upper,
    [Description("lower")]
    Lower,
    [Description("capitalize")]
    Capitalize,
    [Description("link")]
    Link,
    [Description("small-text")]
    SmallText,
    [Description("medium-text")]
    MediumText,
    [Description("large-text")]
    LargeText
}
