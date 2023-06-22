﻿using System.ComponentModel;

namespace BlazorBeerCss.Helpers;

public enum BeerDividers
{
    [Description("divider")]
    Divider,
    [Description("small-divider")]
    SmallDivider,
    [Description("medium-divider")]
    MediumDivider,
    [Description("large-divider")]
    LargeDivider
}
