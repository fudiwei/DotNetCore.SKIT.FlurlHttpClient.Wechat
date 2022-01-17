using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class ReflectionUtility
    {
        private const string PROPERTY_NAME_N_ARRAY = "#$n";

        private static PropertyInfo[] GetJsonProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.CanRead && p.CanWrite && !p.GetCustomAttributes<Newtonsoft.Json.JsonIgnoreAttribute>(inherit: true).Any())
                .ToArray();
        }

        public static T DeserializeFromJson<T>(ref Newtonsoft.Json.Linq.JToken jToken, Newtonsoft.Json.JsonSerializer? serializer = null)
            where T : class, new()
        {
            T result = new T();
            foreach (PropertyInfo property in GetJsonProperties(typeof(T)))
            {
                string key = property.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true)?.PropertyName ?? property.Name;
                object? value = serializer is null ? 
                    jToken[key]?.ToObject(property.PropertyType) : 
                    jToken[key]?.ToObject(property.PropertyType, serializer);
                property.SetValue(result, value);

                // TODO: $n
            }
            return result;
        }

        public static T DeserializeFromJson<T>(ref System.Text.Json.JsonElement jElement)
            where T : class, new()
        {
            T result = new T();
            foreach (PropertyInfo property in GetJsonProperties(typeof(T)))
            {
                string key = property.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true)?.PropertyName ?? property.Name;
                if (jElement.TryGetProperty(key, out System.Text.Json.JsonElement jValue))
                {
                    //property.SetValue(result, value);
                }

                // TODO: $n
            }
            return result;
        }
    }
}
