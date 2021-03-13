using System;
using System.Collections;
using System.Reflection;
using System.Text;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static string ToDescriptionString(this object @this)
        {
            if (@this == null)
                return string.Empty;

            return ToDescriptionString(@this, new StringBuilder()).ToString();
        }

        private static StringBuilder ToDescriptionString(object @this, StringBuilder stringBuilder)
        {
            if (@this == null)
                return stringBuilder;

            Type objType = @this.GetType();
            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (PropertyInfo property in properties)
            {
                object @value = property.GetValue(@this);

                if (@value.Null())
                    stringBuilder.AppendLine(string.Format("{0}: null [{1}]", property.Name, property.PropertyType));
                else if (property.PropertyType.ToString() == @value.ToString())
                    stringBuilder.AppendLine(string.Format("{0}: {1}", property.Name, @value));
                else
                    stringBuilder.AppendLine(string.Format("{0}: {1} [{2}]", property.Name, @value, property.PropertyType));
            }
            return stringBuilder;
        }
    }
}