using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static partial class JsonUtility
    {
        public const string PROPERTY_NAME_NARRAY = "#n";

        private static bool TryMatchNArrayIndex(string key, out int index)
        {
            Regex regex = new Regex(@"(_)(\d+)", RegexOptions.Compiled);
            if (regex.IsMatch(key))
            {
                string str = regex.Match(key).Groups[2].Value;
                index = int.Parse(str);
                return true;
            }

            index = -1;
            return false;
        }

        private static Array CreateOrExpandNArray(object? array, Type elementType, int capacity)
        {
            if (elementType == null) throw new ArgumentException(nameof(elementType));
            if (capacity <= 0) throw new ArgumentException(nameof(capacity));

            if (array == null)
            {
                return Array.CreateInstance(elementType, capacity);
            }

            Array src = (Array)array;
            if (src.Length < capacity)
            {
                Array dst = Array.CreateInstance(elementType, capacity);
                Array.Copy(src, dst, src.Length);
                return dst;
            }

            return src;
        }

        private static object CreateOrUpdateNArrayElement(Array array, Type elementType, int index, string key, object value)
        {
            if (array == null) throw new ArgumentException(nameof(array));
            if (elementType == null) throw new ArgumentException(nameof(elementType));

            static object CreateNArrayElementIfEmpty(Array array, Type elementType, int index)
            {
                object? element = array.GetValue(index);
                if (element == null)
                {
                    if (elementType.IsAbstract || elementType.IsInterface)
                    {
                        throw new NotSupportedException();
                    }
                    else if (elementType.IsArray)
                    {
                        element = Array.CreateInstance(elementType, 0);
                    }
                    else
                    {
                        element = Activator.CreateInstance(elementType);
                    }
                }

                array.SetValue(element, index);
                return element;
            }

            object? element = CreateNArrayElementIfEmpty(array, elementType, index);

            if (value is Newtonsoft.Json.Linq.JToken jToken)
            {
                var props = GetTypedNewtonsoftJsonProperties(elementType);
                var prop = props.SingleOrDefault(p => string.Equals(p.PropertyName.Replace("$n", index.ToString()), key));
                if (prop != null)
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    foreach (Newtonsoft.Json.JsonConverterAttribute attribute in prop.PropertyInfo.GetCustomAttributes<Newtonsoft.Json.JsonConverterAttribute>(inherit: true))
                    {
                        Newtonsoft.Json.JsonConverter converter = (Newtonsoft.Json.JsonConverter)Activator.CreateInstance(attribute.ConverterType, attribute.ConverterParameters);
                        serializer.Converters.Add(converter);
                    }
                    
                    object tmp = jToken.ToObject(prop.PropertyType, serializer);
                    prop.PropertyInfo.SetValue(element, tmp);
                }
            }
            else if (value is System.Text.Json.JsonElement jElement)
            {
                // TODO
            }
            else
            {
                throw new ArgumentException(nameof(value));
            }

            return element;
        }

        public static T DeserializeWhenHasNArray<T>(ref Newtonsoft.Json.Linq.JObject jObject, Newtonsoft.Json.JsonSerializer? serializer = null)
            where T : class, new()
        {
            var props = GetTypedNewtonsoftJsonProperties(typeof(T));
            if (props.Count(p => p.IsNArrayProperty) != 1)
                throw new Newtonsoft.Json.JsonException("The number of `_$n` properties must be only one.");

            T result = new T();
            foreach (Newtonsoft.Json.Linq.JProperty jKey in jObject.Properties())
            {
                var prop = props.SingleOrDefault(e => e.PropertyName == jKey.Name);
                if (prop != null)
                {
                    // 处理普通属性
                    object? value = serializer is null ?
                        jObject[prop.PropertyName]?.ToObject(prop.PropertyType) :
                        jObject[prop.PropertyName]?.ToObject(prop.PropertyType, serializer);
                    prop.PropertyInfo.SetValue(result, value);
                }
                else if (TryMatchNArrayIndex(jKey.Name, out int index))
                {
                    // 处理 $n 属性
                    var narrProp = props.Single(e => e.IsNArrayProperty);
                    object? value = narrProp.PropertyInfo.GetValue(result);

                    Array array = CreateOrExpandNArray(value, narrProp.PropertyType.GetElementType(), index + 1);
                    object? element = CreateOrUpdateNArrayElement(array, narrProp.PropertyType.GetElementType(), index, jKey.Name, jKey.Value);
                    narrProp.PropertyInfo.SetValue(result, array);
                }
                else if (serializer?.MissingMemberHandling == Newtonsoft.Json.MissingMemberHandling.Error)
                {
                    throw new Newtonsoft.Json.JsonSerializationException($"Could not find member `{jKey.Name}` on object of type `{typeof(T).Name}`.");
                }
            }
            return result;
        }

        public static T DeserializeWhenHasNArray<T>(ref System.Text.Json.JsonElement jElement, System.Text.Json.JsonSerializerOptions options = null)
            where T : class, new()
        {
            var props = GetTypedSystemTextJsonProperties(typeof(T));
            if (props.Count(p => p.IsNArrayProperty) != 1)
                throw new System.Text.Json.JsonException("The number of `$n` properties must be only one.");

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

    partial class JsonUtility
    {
        private sealed class TypedJsonProperty
        {
            public string PropertyName { get; }

            public PropertyInfo PropertyInfo { get; }

            public Type PropertyType { get { return PropertyInfo.PropertyType; } }

            public bool IsNArrayProperty { get; }

            public TypedJsonProperty(string propertyName, PropertyInfo propertyInfo, bool isNArrayProperty)
            {
                PropertyName = propertyName;
                PropertyInfo = propertyInfo;
                IsNArrayProperty = isNArrayProperty;
            }
        }

        private static readonly Hashtable _mappedTypeJsonProperties = new Hashtable();

        private static TypedJsonProperty[] GetTypedNewtonsoftJsonProperties(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            string skey = "Newtosoft.Json:" + (type.AssemblyQualifiedName ?? type.GetHashCode().ToString());
            var props = (TypedJsonProperty[])_mappedTypeJsonProperties[skey];
            if (props == null)
            {
                props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => p.CanRead && p.CanWrite && !p.GetCustomAttributes<Newtonsoft.Json.JsonIgnoreAttribute>(inherit: true).Any())
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                        return new TypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            isNArrayProperty: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType().IsClass
                        );
                    })
                    .ToArray();
                _mappedTypeJsonProperties[skey] = props;
            }

            return props;
        }

        private static TypedJsonProperty[] GetTypedSystemTextJsonProperties(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            string skey = "System.Text.Json:" + (type.AssemblyQualifiedName ?? type.GetHashCode().ToString());
            var props = (TypedJsonProperty[])_mappedTypeJsonProperties[skey];
            if (props == null)
            {
                props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => p.CanRead && p.CanWrite && !p.GetCustomAttributes<Newtonsoft.Json.JsonIgnoreAttribute>(inherit: true).Any())
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                        return new TypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            isNArrayProperty: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType().IsClass
                        );
                    })
                    .ToArray();
                _mappedTypeJsonProperties[skey] = props;
            }

            return props;
        }
    }
}
