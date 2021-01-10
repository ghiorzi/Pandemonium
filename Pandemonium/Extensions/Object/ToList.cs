using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It creates a single item list 
        /// </summary>
        public static List<T> ToList<T>(this T @this) 
            => new List<T>() { @this };
    }
}