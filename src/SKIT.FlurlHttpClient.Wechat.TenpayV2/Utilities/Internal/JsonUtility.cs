using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static partial class JsonUtility
    {
        public const string PROPERTY_WILDCARD_NARRAY_ELEMENT = "$n";
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
            if (elementType == null) throw new ArgumentNullException(nameof(elementType));
            if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));

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

        private static object CreateOrUpdateNArrayElement(Array array, Type elementType, int index, string key, object value, params object?[]? args)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (elementType == null) throw new ArgumentNullException(nameof(elementType));

            static object AppendNArrayElement(Array array, Type elementType, int index)
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
                return element!;
            }

            object? element = AppendNArrayElement(array, elementType, index);

            if (value is Newtonsoft.Json.Linq.JToken jToken)
            {
                var props = GetTypedNewtonsoftJsonProperties(elementType);
                var prop = props.SingleOrDefault(p => string.Equals(p.PropertyName.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, index.ToString()), key));
                if (prop != null)
                {
                    Newtonsoft.Json.JsonSerializer? serializer = args?.FirstOrDefault() as Newtonsoft.Json.JsonSerializer;
                    if (serializer == null)
                    {
                        serializer = Newtonsoft.Json.JsonSerializer.CreateDefault();
                    }

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
                var props = GetTypedSystemTextJsonProperties(elementType);
                var prop = props.SingleOrDefault(p => string.Equals(p.PropertyName.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, index.ToString()), key));
                if (prop != null)
                {
                    System.Text.Json.JsonSerializerOptions? options = (args?.FirstOrDefault() as System.Text.Json.JsonSerializerOptions);
                    if (options == null)
                    {
                        options = new System.Text.Json.JsonSerializerOptions();
                    }
                    else
                    {
                        options = new System.Text.Json.JsonSerializerOptions(options);
                    }

                    foreach (System.Text.Json.Serialization.JsonConverterAttribute attribute in prop.PropertyInfo.GetCustomAttributes<System.Text.Json.Serialization.JsonConverterAttribute>(inherit: true))
                    {
                        System.Text.Json.Serialization.JsonConverter converter = (System.Text.Json.Serialization.JsonConverter)Activator.CreateInstance(attribute.ConverterType!);
                        options.Converters.Add(converter!);
                    }

                    object tmp = System.Text.Json.JsonSerializer.Deserialize(jElement, prop.PropertyType, options)!;
                    prop.PropertyInfo.SetValue(element, tmp);
                }
            }
            else
            {
                throw new NotSupportedException();
            }

            return element;
        }

        public static string SerializeWhenHasNArray<T>(T obj, Newtonsoft.Json.JsonSerializer? serializer = null)
            where T : class, new()
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            static Newtonsoft.Json.Linq.JToken Flatten(Newtonsoft.Json.Linq.JToken jToken)
            {
                if (jToken.Type == Newtonsoft.Json.Linq.JTokenType.Array)
                {
                    foreach (Newtonsoft.Json.Linq.JToken? jSubToken in jToken)
                    {
                        if (jSubToken == null)
                            continue;

                        Flatten(jSubToken);
                    }
                }
                else if (jToken.Type == Newtonsoft.Json.Linq.JTokenType.Object)
                {
                    string[] keys = ((Newtonsoft.Json.Linq.JObject)jToken).Properties().Select(p => p.Name).ToArray();
                    foreach (string key in keys)
                    {
                        if (!PROPERTY_NAME_NARRAY.Equals(key))
                            continue;

                        int i = 0;
                        foreach (Newtonsoft.Json.Linq.JToken? jSubToken in jToken[key])
                        {
                            if (jSubToken == null)
                                continue;

                            foreach (Newtonsoft.Json.Linq.JProperty jSubKey in jSubToken)
                            {
                                jToken[jSubKey.Name.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, i.ToString())] = jSubKey.Value;
                            }

                            i++;
                        }
                    }

                    jToken[PROPERTY_NAME_NARRAY]?.Parent?.Remove();
                }

                return jToken;
            }

            //StringBuilder stringBuilder = new StringBuilder();
            //using TextWriter stringWriter = new StringWriter(stringBuilder);
            //serializer = serializer ?? Newtonsoft.Json.JsonSerializer.CreateDefault();
            //serializer.Serialize(stringWriter, obj, typeof(T));
            //string rawJson = stringBuilder.ToString();

            //Newtonsoft.Json.Linq.JToken jToken = Newtonsoft.Json.Linq.JToken.Parse(rawJson);
            //return Flatten(jToken).ToString(serializer.Formatting);

            // TODO
            return default!;
        }

        public static T DeserializeWhenHasNArray<T>(ref Newtonsoft.Json.Linq.JObject jObject, Newtonsoft.Json.JsonSerializer? serializer = null)
            where T : class, new()
        {
            var props = GetTypedNewtonsoftJsonProperties(typeof(T));
            if (props.Count(p => p.IsNArrayProperty) != 1)
                throw new Newtonsoft.Json.JsonException("The number of `$n` properties must be only one.");

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

                    Array array = CreateOrExpandNArray(value, narrProp.PropertyType.GetElementType()!, index + 1);
                    object? element = CreateOrUpdateNArrayElement(array, narrProp.PropertyType.GetElementType()!, index, jKey.Name, jKey.Value, serializer);
                    narrProp.PropertyInfo.SetValue(result, array);
                }
                else if (serializer?.MissingMemberHandling == Newtonsoft.Json.MissingMemberHandling.Error)
                {
                    throw new Newtonsoft.Json.JsonSerializationException($"Could not find member `{jKey.Name}` on object of type `{typeof(T).Name}`.");
                }
            }
            return result;
        }

        public static string SerializeWhenHasNArray<T>(T obj, System.Text.Json.JsonSerializerOptions? options = null)
            where T : class, new()
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            if (obj == null) throw new ArgumentNullException(nameof(obj));

            static System.Text.Json.Nodes.JsonNode Flatten(
                System.Text.Json.Nodes.JsonNode jNode, 
                System.Text.Json.JsonSerializerOptions jsonSerializerOptions,
                System.Text.Json.JsonDocumentOptions jsonDocumentOptions,
                System.Text.Json.Nodes.JsonNodeOptions jsonNodeOptions)
            {
                if (jNode is System.Text.Json.Nodes.JsonArray jNodeAsArray)
                {
                    foreach (System.Text.Json.Nodes.JsonNode? jSubNode in jNodeAsArray)
                    {
                        if (jSubNode == null)
                            continue;

                        Flatten(jSubNode, jsonSerializerOptions, jsonDocumentOptions, jsonNodeOptions);
                    }
                }
                else if (jNode is System.Text.Json.Nodes.JsonObject jNodeAsObject)
                {
                    string[] keys = jNodeAsObject.Select(e => e.Key).ToArray();
                    foreach (string key in keys)
                    {
                        if (!PROPERTY_NAME_NARRAY.Equals(key))
                            continue;

                        int i = 0;
                        foreach (System.Text.Json.Nodes.JsonObject? jSubNode in jNodeAsObject[key]!.AsArray())
                        {
                            if (jSubNode == null)
                                continue;

                            foreach (var jSubKey in jSubNode)
                            {
                                string? json = jSubKey.Value?.ToJsonString(jsonSerializerOptions);
                                if (json != null)
                                    jNodeAsObject[jSubKey.Key.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, i.ToString())] = System.Text.Json.Nodes.JsonNode.Parse(json, jsonNodeOptions, jsonDocumentOptions);
                            }

                            i++;
                        }
                    }

                    jNodeAsObject.Remove(PROPERTY_NAME_NARRAY);
                }

                return jNode;
            }

            // NOTICE: 因为外层 JsonConverter 的缘故，这里不能使用 Newtonsoft.Json 序列化，会递归死循环
            StringBuilder stringBuilder = new StringBuilder();
            using TextWriter stringWriter = new StringWriter(stringBuilder);
            Newtonsoft.Json.JsonSerializer serializer = Newtonsoft.Json.JsonSerializer.CreateDefault();
            serializer.Serialize(stringWriter, obj, typeof(T));
            string rawJson = stringBuilder.ToString();

            System.Text.Json.JsonSerializerOptions jsonSerializerOptions = options ?? new System.Text.Json.JsonSerializerOptions();
            System.Text.Json.JsonDocumentOptions jsonDocumentOptions = new System.Text.Json.JsonDocumentOptions()
            {
                AllowTrailingCommas = jsonSerializerOptions.AllowTrailingCommas,
                CommentHandling = jsonSerializerOptions.ReadCommentHandling,
                MaxDepth = jsonSerializerOptions.MaxDepth
            };
            System.Text.Json.Nodes.JsonNodeOptions jsonNodeOptions = new System.Text.Json.Nodes.JsonNodeOptions()
            {
                PropertyNameCaseInsensitive = jsonSerializerOptions.PropertyNameCaseInsensitive
            };
            System.Text.Json.Nodes.JsonNode jNode = System.Text.Json.Nodes.JsonNode.Parse(rawJson, jsonNodeOptions, jsonDocumentOptions)!;
            return Flatten(jNode, jsonSerializerOptions, jsonDocumentOptions, jsonNodeOptions)
                .ToJsonString(new System.Text.Json.JsonSerializerOptions() 
                { 
                    WriteIndented = jsonSerializerOptions.WriteIndented,
                    Encoder = jsonSerializerOptions.Encoder
                });
        }

        public static T DeserializeWhenHasNArray<T>(ref System.Text.Json.JsonElement jElement, System.Text.Json.JsonSerializerOptions? options = null)
            where T : class, new()
        {
            var props = GetTypedSystemTextJsonProperties(typeof(T));
            if (props.Count(p => p.IsNArrayProperty) != 1)
                throw new System.Text.Json.JsonException("The number of `$n` properties must be only one.");

            T result = new T();
            foreach (System.Text.Json.JsonProperty jKey in jElement.EnumerateObject())
            {
                var prop = props.SingleOrDefault(e => e.PropertyName == jKey.Name);
                if (prop != null)
                {
                    // 处理普通属性
                    object? value = options is null ?
                        System.Text.Json.JsonSerializer.Deserialize(jKey.Value, prop.PropertyType, options) :
                        System.Text.Json.JsonSerializer.Deserialize(jKey.Value, prop.PropertyType, options);
                    prop.PropertyInfo.SetValue(result, value);
                }
                else if (TryMatchNArrayIndex(jKey.Name, out int index))
                {
                    // 处理 $n 属性
                    var narrProp = props.Single(e => e.IsNArrayProperty);
                    object? value = narrProp.PropertyInfo.GetValue(result);

                    Array array = CreateOrExpandNArray(value, narrProp.PropertyType.GetElementType()!, index + 1);
                    object? element = CreateOrUpdateNArrayElement(array, narrProp.PropertyType.GetElementType()!, index, jKey.Name, jKey.Value, options);
                    narrProp.PropertyInfo.SetValue(result, array);
                }
            }
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
            var props = (TypedJsonProperty[]?)_mappedTypeJsonProperties[skey];
            if (props == null)
            {
                props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => 
                        (p.CanRead && !p.GetCustomAttributes<Newtonsoft.Json.JsonIgnoreAttribute>(inherit: true).Any()) &&
                        (p.CanWrite || p.GetCustomAttributes<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true).Any())
                    )
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                        return new TypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            isNArrayProperty: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass
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
            var props = (TypedJsonProperty[]?)_mappedTypeJsonProperties[skey];
            if (props == null)
            {
                props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => 
                        (p.CanRead && !p.GetCustomAttributes<System.Text.Json.Serialization.JsonIgnoreAttribute>(inherit: true).Any()) &&
                        (p.CanWrite || p.GetCustomAttributes<System.Text.Json.Serialization.JsonIncludeAttribute>(inherit: true).Any())
                    )
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<System.Text.Json.Serialization.JsonPropertyNameAttribute>(inherit: true)?.Name ?? p.Name;
                        return new TypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            isNArrayProperty: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass
                        );
                    })
                    .ToArray();
                _mappedTypeJsonProperties[skey] = props;
            }

            return props;
        }
    }
}
