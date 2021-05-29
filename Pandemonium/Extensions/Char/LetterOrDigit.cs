using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is a letter OR a digit, otherwise returns false
        /// </summary> 
        public static bool LetterOrDigit(this char self) 
            => Char.IsLetter(self) || Char.IsDigit(self);
    }
}