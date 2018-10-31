using System;
using System.Globalization;

namespace CastleWindsorWebFormsExample
{
    public static class TypeExtensions
    {
        public static bool IsWebFormsComponent(this Type type)
        {
            return type.Namespace.StartsWith("ASP", true, CultureInfo.InvariantCulture);
        }
    }
}