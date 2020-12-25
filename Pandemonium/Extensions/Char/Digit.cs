using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if value is a digit, otherwise returns false
        /// </summary>
        public static bool Digit(this char @this) 
            => Char.IsDigit(@this);
    }
}