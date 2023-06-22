﻿using System.ComponentModel;

namespace BlazorBeerCssLibrary.Helpers;

public enum BeerResponsive
{
    [Description("")]
    Default,
    [Description("responsive")]
    Responsive,
    [Description("s")]
    Small,
    [Description("m")]
    Medium,
    [Description("l")]
    Large
}