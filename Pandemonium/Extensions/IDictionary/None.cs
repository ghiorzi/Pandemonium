using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if there's no key equal to @keys, otherwise returns false
        /// </summary>
        public static bool None<TKey, TValue>(this IDictionary<TKey, TValue> @this, params TKey[] keys)
            => !@this.Any(keys);
    }
}