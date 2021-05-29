using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not a letter, otherwise returns false
        /// </summary> 
        public static bool NotLetter(this char self) 
            => !Char.IsLetter(self);
    }
}