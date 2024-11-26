using Extension.Cache.N6.Interface.Cahce;
using Microsoft.Extensions.Caching.Memory;

namespace Extension.Cache.N6.Cache
{

    public class ExtensionCache : IExtensionCache
    {
        private readonly IMemoryCache _memoryCache;

        public ExtensionCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public T GetData<T>(string key)
        {
            _memoryCache.TryGetValue(key, out T query);
            return query;
        }

        public void SetData<T>(T TEntity, string key, int lifeTimeInMinutes)
        {
            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(lifeTimeInMinutes));

            _memoryCache.Set(key, TEntity, cacheOptions);
        }
    }
    
}
