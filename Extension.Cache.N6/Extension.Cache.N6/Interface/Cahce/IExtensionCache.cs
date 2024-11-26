namespace Extension.Cache.N6.Interface.Cahce
{
    public interface IExtensionCache
    {
        void SetData<T>(T TEntity, string key, int lifeTimeInMinutes);

        T GetData<T>(string key);
    }
}
