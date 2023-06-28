using System.ComponentModel;
using System.Reflection;

namespace BlazorBeerCss.Extensions;

public static class EnumsExtensions
{
    public static T GetEnumValueByDescription<T>(this string description) where T : Enum
    {
        foreach (Enum enumItem in Enum.GetValues(typeof(T)))
        {
            if (enumItem.GetEnumDescription() == description)
            {
                return (T)enumItem;
            }
        }
        throw new ArgumentException("Not found.", nameof(description));
    }

    public static string GetEnumDescription(this Enum enumValue)
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());

        if(field == null)
            throw new ArgumentNullException("Item was null.", nameof(enumValue));

        if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
        {
            return attribute.Description;
        }
        throw new ArgumentException("Item not found.", nameof(enumValue));
    }

    public static T GetEnumValueFromDescription<T>(string description)
    {
        MemberInfo[] fis = typeof(T).GetFields();

        foreach (var fi in fis)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0 && attributes[0].Description == description)
                return (T)Enum.Parse(typeof(T), fi.Name);
        }

        throw new Exception("Not found");
    }
}
