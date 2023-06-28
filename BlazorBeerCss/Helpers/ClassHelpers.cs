using BlazorBeerCss.Extensions;
using System.Text;

namespace BlazorBeerCss;

public static class ClassHelpers
{
    public static string CreateClass(string baseClass, params Enum[] ToBeAdded)
    {
        StringBuilder sb = new StringBuilder(baseClass, 50);
        
        foreach (var item in ToBeAdded)
        {
            if (item.GetEnumDescription() != "")
                sb.Append($" {item.GetEnumDescription()}");
        }

        return sb.ToString();
    }
}