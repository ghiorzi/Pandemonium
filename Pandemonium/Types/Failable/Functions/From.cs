using System;

namespace Pandemonium.Types
{
    public static partial class Failable
    {
        public static Failable<T> From<T>(T value)
        {
            if (value is Exception)
                return FromException<T>(value as Exception);
            
            return new Failable<T>(value);
        }
        
        public static Failable<T> FromException<T>(Exception error)
            => new (error);
    }
}