using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class JsonUtility
    {
        private const string PROPERTY_NAME_N_ARRAY = "#$n";

        public static T DeserializeWhenHasNArray<T>(ref Newtonsoft.Json.Linq.JObject jObject, Newtonsoft.Json.JsonSerializer? serializer = null)
            where T : class, new()
        {
            var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.CanRead && p.CanWrite && !p.GetCustomAttributes<Newtonsoft.Json.JsonIgnoreAttribute>(inherit: true).Any())
                .Select(p =>
                {
                    string name = p.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                    return new
                    {
                        Name = name,
                        RawInfo = p,
                        IsNArray = PROPERTY_NAME_N_ARRAY.Equals(name)
                    };
                })
                .ToArray();

            T result = new T();
            foreach (var jKey in jObject.Properties())
            {
                var prop = props.SingleOrDefault(e => e.Name == jKey.Name);
                if (prop != null)
                {
                    // 处理普通属性
                    object? value = serializer is null ?
                        jObject[prop.Name]?.ToObject(prop.RawInfo.PropertyType) :
                        jObject[prop.Name]?.ToObject(prop.RawInfo.PropertyType, serializer);
                    prop.RawInfo.SetValue(result, value);
                }
                else
                {
                    // 处理 $n 属性
                    var propNArray = props.SingleOrDefault(e => e.IsNArray);
                    if (propNArray == null)
                        continue;

                    // TODO:
                }
            }
            return result;
        }

        public static T DeserializeWhenHasNArray<T>(ref System.Text.Json.JsonElement jElement)
            where T : class, new()
        {
            var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.CanRead && p.CanWrite && !p.GetCustomAttributes<System.Text.Json.Serialization.JsonIgnoreAttribute>(inherit: true).Any())
                .Select(p =>
                {
                    string name = p.GetCustomAttribute<System.Text.Json.Serialization.JsonPropertyNameAttribute>(inherit: true)?.Name ?? p.Name;
                    return new
                    {
                        Name = name,
                        RawInfo = p,
                        IsNArray = PROPERTY_NAME_N_ARRAY.Equals(name)
                    };
                })
                .ToArray();

            T result = new T();
            //foreach (var property in props)
            //{
            //    if (jElement.TryGetProperty(property.Name, out System.Text.Json.JsonElement jValue))
            //    {
            //    }

            //    // TODO: $n
            //}
            return result;
        }
    }
}
