using System;
using System.Web;
using System.Web.Caching;

namespace VelibLibrary
{
    public static class CacheExtension
    {
        private static Cache applicationCache = HttpRuntime.Cache;

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
            applicationCache.Insert(key, value, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(5));
        }

        // Retrives value from the cache given a key
        public static T Get<T>(string key)
        {
            return (T)applicationCache[key];
        }
    }
}
