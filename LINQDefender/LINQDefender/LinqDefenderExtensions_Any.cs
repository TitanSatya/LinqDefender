using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDefender
{
    public static class LinqDefenderExtensions_Any
    {
        /// <summary>
        /// If Any value is there then return true or return false.
        /// If Collection is null then return false.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static bool AnyOnNull<T>(this IEnumerable<T> collection) where T : new()
        {
            if (collection == null)
            {
                return false;
            }
            else
            {
                return collection.Any();
            }
        }

        /// <summary>
        /// If Any value is there then return true or return false.
        /// If Collection is null then return false.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static bool AnyOnNull<T>(this IEnumerable<T> collection, Func<T, bool> predicate) where T : new()
        {
            if (collection == null)
            {
                return false;
            }
            else
            {
                return collection.Any(predicate);
            }
        }
    }
}