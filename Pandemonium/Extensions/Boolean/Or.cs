﻿namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It return true when at least one value is true
        /// </summary>
        public static bool Or(this bool self, bool value)
            => self || value;
    }
}