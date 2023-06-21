using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBeerCssLibrary.Helpers;

public enum Border
{
    [Description("border")]
    Border,
    [Description("round")]
    Round,
    [Description("no-round")]
    NoRound,
    [Description("left-round")]
    LeftRound,
    [Description("top-round")]
    TopRound,
    [Description("right-round")]
    RightRound,
    [Description("bottom-round")]
    BottomRound
}
