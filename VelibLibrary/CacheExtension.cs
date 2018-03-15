using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;

namespace VelibLibrary
{
    public static class CacheExtension
    {
        private static Cache applicationCache = HttpRuntime.Cache;

        private static DateTime absoluteExpiration = Cache.NoAbsoluteExpiration;
        private static TimeSpan slidingExpiration = TimeSpan.FromMinutes(5);

        // Cache getter
        public static Cache Cache
        {
            get { return applicationCache; }
        }

        // Adds an item to the cache given a key and its value
        // I prefer delay the deletion so that the cache is more efficient
        // Last Cache.Add(...) method's attribute is null because I don't want
        // the user to be warned when an item is removed from the cache
        public static void Add<T>(string key, T value)
        {
            applicationCache.Insert(key, value, null, absoluteExpiration, slidingExpiration);
        }

        // Retrives value from the cache given a key
        public static T Get<T>(string key)
        {
            return (T)applicationCache[key];
        }

        public static DateTime AbsoluteExpiration
        {
            get { return absoluteExpiration; }
            set { absoluteExpiration = value; }
        }

        public static TimeSpan SlidingExpiration
        {
            get { return slidingExpiration; }
            set { slidingExpiration = value; }
        }

        public static void ClearCache()
        {
            List<String> keys = new List<String>();
            IDictionaryEnumerator enumerator = Cache.GetEnumerator();

            while (enumerator.MoveNext())
            {
                keys.Add(enumerator.Key.ToString());
            }

            for (int i = 0; i < keys.Count; i++)
            {
                Cache.Remove(keys[i]);
            }
        }
    }
}
