using Extension.Cache.N6.Cache;
using Extension.Cache.N6.Interface.Cahce;
using Microsoft.Extensions.DependencyInjection;

namespace Extension.Cache.N6
{
    public static class DependencyInjection
    {
        public static void AddMemoryCachePersistencia(this IServiceCollection services)
        {
            services.AddScoped<IExtensionCache, ExtensionCache>();
        }
    }
}
