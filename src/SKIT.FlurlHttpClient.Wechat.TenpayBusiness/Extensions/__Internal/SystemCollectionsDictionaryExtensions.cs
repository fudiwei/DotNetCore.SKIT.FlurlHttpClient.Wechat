using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    internal static class SystemCollectionsDictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
#pragma warning disable CS8603
            return dictionary.TryGetValue(key, out var value) ? value : default(TValue);
#pragma warning restore CS8603
        }
    }
}
