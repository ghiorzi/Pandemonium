using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Methods
    {
        private const sbyte APRIL = 4;

        public static DateTime April(this int @this, int year) 
            => new DateTime(year, APRIL, @this);
        
        public static DateTime April(this int @this, int year, Calendar calendar) 
            => new DateTime(year, APRIL, @this, calendar);

        public static DateTime April(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, APRIL, @this, hour, minute, second);

        public static DateTime April(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, APRIL, @this, hour, minute, second, kind);

        public static DateTime April(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, APRIL, @this, hour, minute, second, calendar);

        public static DateTime April(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, APRIL, @this, hour, minute, second, millisecond);

        public static DateTime April(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, APRIL, @this, hour, minute, second, millisecond, kind);
    }
}