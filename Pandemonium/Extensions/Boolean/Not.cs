﻿namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It inverts the value (true => false, false => true)
        public static bool Not(this bool @this) 
            => !@this;
    }
}