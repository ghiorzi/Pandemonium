using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if value is a letter, otherwise returns false
        /// </summary> 
        public static bool Letter(this char @this) 
            => Char.IsLetter(@this);
    }
}