using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDefender
{
    public static class LINQDefenderExtensions_FirstOrDefault
    {
        public static T FirstOrDefaultOnNull<T>(this IEnumerable<T> collection) where T : new()
        {
            if (collection == null)
            {
                return new T();
            }
            else
            {
                return collection.FirstOrDefault();
            }
        }

        public static T FirstOrDefaultOnNull<T>(this IEnumerable<T> collection, Func<T, bool> predicate) where T : new()
        {
            if (collection == null)
            {
                return new T();
            }
            else
            {
                return collection.FirstOrDefault(predicate);
            }
        }
    }
}