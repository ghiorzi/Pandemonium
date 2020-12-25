using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Methods
    {
        private const sbyte FEBRUARY = 2;

        public static DateTime February(this int @this, int year)
            => new DateTime(year, FEBRUARY, @this);
        
        public static DateTime February(this int @this, int year, Calendar calendar) 
            => new DateTime(year, FEBRUARY, @this, calendar);

        public static DateTime February(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, FEBRUARY, @this, hour, minute, second);

        public static DateTime February(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, FEBRUARY, @this, hour, minute, second, kind);

        public static DateTime February(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, FEBRUARY, @this, hour, minute, second, calendar);

        public static DateTime February(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, FEBRUARY, @this, hour, minute, second, millisecond);

        public static DateTime February(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, FEBRUARY, @this, hour, minute, second, millisecond, kind);
    }
}