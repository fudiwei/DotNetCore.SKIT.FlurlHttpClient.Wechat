using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace System.Text.Json.Converters
{
    internal static class FlattenNArrayObjectConverterBase
    {
        public const string PROPERTY_WILDCARD_NARRAY_ELEMENT = Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_WILDCARD_NARRAY_ELEMENT;
        public const string PROPERTY_NAME_NARRAY = Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY;
    }

    internal class FlattenNArrayObjectConverterBase<T> : JsonConverter<T?>
        where T : class, new()
    {
        private sealed class InnerTypedJsonProperty
        {
            public string PropertyName { get; }

            public PropertyInfo PropertyInfo { get; }

            public Type PropertyType { get { return PropertyInfo.PropertyType; } }

            public bool PropertyIsNArray { get; }

            public JsonConverter? JsonConverter { get; }

            public InnerTypedJsonProperty(string propertyName, PropertyInfo propertyInfo, bool propertyIsNArray, JsonConverter? jsonConverter)
            {
                PropertyName = propertyName;
                PropertyInfo = propertyInfo;
                PropertyIsNArray = propertyIsNArray;
                JsonConverter = jsonConverter;
            }
        }

        private const string PROPERTY_WILDCARD_NARRAY_ELEMENT = FlattenNArrayObjectConverterBase.PROPERTY_WILDCARD_NARRAY_ELEMENT;
        private const string PROPERTY_NAME_NARRAY = FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY;

        private static readonly Hashtable _mappedTypeJsonProperties = new Hashtable();

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                InnerTypedJsonProperty[] typedJsonProperties = GetTypedJsonProperties(typeToConvert);
                if (typedJsonProperties.Count(p => p.PropertyIsNArray) != 1)
                    throw new JsonException("The number of `$n` properties must be only one.");

                JsonElement jElement = JsonDocument.ParseValue(ref reader).RootElement.Clone();
                T tObject = new T();

                foreach (JsonProperty jKey in jElement.EnumerateObject())
                {
                    InnerTypedJsonProperty? typedJsonProperty = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jKey.Name);
                    if (typedJsonProperty != null)
                    {
                        // 处理普通属性
                        JsonSerializerOptions tmpOptions = options;
                        if (typedJsonProperty.JsonConverter != null)
                        {
                            tmpOptions = new JsonSerializerOptions(options);
                            tmpOptions.Converters.Add(typedJsonProperty.JsonConverter);
                        }

                        object? value = JsonSerializer.Deserialize(jKey.Value, typedJsonProperty.PropertyType, tmpOptions);
                        typedJsonProperty.PropertyInfo.SetValue(tObject, value);
                    }
                    else if (TryMatchNArrayIndex(jKey.Name, out int index))
                    {
                        // 处理 $n 属性
                        InnerTypedJsonProperty narrayJsonProperty = typedJsonProperties.Single(e => e.PropertyIsNArray);
                        object? value = narrayJsonProperty.PropertyInfo.GetValue(tObject);

                        JsonSerializerOptions tmpOptions = options;

                        Array array = CreateOrExpandNArray(value, narrayJsonProperty.PropertyType.GetElementType()!, index + 1);
                        object? element = CreateOrUpdateNArrayElement(array, index, jKey.Name, jKey.Value, tmpOptions);
                        narrayJsonProperty.PropertyInfo.SetValue(tObject, array);
                    }
                }
                return tObject;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();

            foreach (InnerTypedJsonProperty typedJsonProperty in GetTypedJsonProperties(value.GetType()))
            {
                if (!typedJsonProperty.PropertyIsNArray)
                {
                    // 处理普通属性
                    string propertyKey = typedJsonProperty.PropertyName;
                    object? propertyValue = typedJsonProperty.PropertyInfo.GetValue(value);
                    if (propertyValue is null)
                    {
                        if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingNull)
                            continue;
                    }
                    else if (propertyValue == (propertyValue.GetType().IsValueType ? Activator.CreateInstance(propertyValue.GetType()) : null))
                    {
                        if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingDefault)
                            continue;
                    }

                    JsonSerializerOptions tmpOptions = options;
                    JsonConverter? tmpConverter = typedJsonProperty.JsonConverter;
                    if (tmpConverter != null)
                    {
                        tmpOptions = new JsonSerializerOptions(options);
                        tmpOptions.Converters.Add(tmpConverter);
                    }

                    if (tmpConverter != null && CheckTypeIsSubclassOf(tmpConverter.GetType(), typeof(TextualObjectInJsonFormatConverterBase<>)))
                    {
                        // TODO: 优化
                        tmpOptions.Converters.Remove(tmpConverter);
                        writer.WritePropertyName(propertyKey);
                        writer.WriteStringValue(JsonSerializer.Serialize(propertyValue, tmpOptions));
                    }
                    else
                    {
                        writer.WritePropertyName(propertyKey);
                        writer.WriteRawValue(JsonSerializer.Serialize(propertyValue, tmpOptions), skipInputValidation: true);
                    }
                }
                else
                {
                    // 处理 $n 属性
                    Array? array = (Array?)typedJsonProperty.PropertyInfo.GetValue(value);
                    if (array is null)
                        continue;

                    for (int i = 0, len = array.Length; i < len; i++)
                    {
                        object? element = array.GetValue(i);
                        if (element is null)
                            continue;

                        JsonSerializerOptions tmpOptions = options;
                        JsonConverter? tmpConverter = GetTypedJsonConverter(element.GetType());
                        if (tmpConverter != null)
                        {
                            tmpOptions = new JsonSerializerOptions(options);
                            tmpOptions.Converters.Add(tmpConverter);
                        }

                        JsonObject jSubObject = JsonSerializer.SerializeToNode(element, tmpOptions)!.AsObject();
                        foreach (KeyValuePair<string, JsonNode?> jSubKey in jSubObject)
                        {
                            writer.WritePropertyName(jSubKey.Key.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, i.ToString()));
                            writer.WriteRawValue(jSubKey.Value?.ToJsonString(tmpOptions)!, skipInputValidation: true);
                        }
                    }
                }
            }

            writer.WriteEndObject();
        }

        private static JsonConverter? GetTypedJsonConverter(MemberInfo? memberInfo)
        {
            if (memberInfo == null)
                return null;

            return memberInfo.GetCustomAttributes<JsonConverterAttribute>(inherit: true)
                .OrderByDescending(attr => attr.IsDefaultAttribute())
                .Select(attr =>
                {
                    JsonConverter? converter = null;

                    if (memberInfo is Type type)
                    {
                        converter = attr.CreateConverter(type);
                    }
                    else if (memberInfo is PropertyInfo propertyInfo)
                    {
                        converter = attr.CreateConverter(propertyInfo.PropertyType);
                    }

                    if (converter == null && attr.ConverterType != null)
                    {
                        converter = (JsonConverter)Activator.CreateInstance(attr.ConverterType)!;
                    }

                    return converter;
                })
                .FirstOrDefault(converter => converter != null);
        }

        private static InnerTypedJsonProperty[] GetTypedJsonProperties(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            string mappedTypeKey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            InnerTypedJsonProperty[]? typedJsonProperties = (InnerTypedJsonProperty[]?)_mappedTypeJsonProperties[mappedTypeKey];

            if (typedJsonProperties == null)
            {
                typedJsonProperties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p =>
                    {
                        if (p.CanWrite || p.GetCustomAttributes<JsonIncludeAttribute>(inherit: true).Any())
                        {
                            return !p.GetCustomAttributes<JsonIgnoreAttribute>(inherit: false).Any();
                        }

                        return false;
                    })
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<JsonPropertyNameAttribute>(inherit: true)?.Name ?? p.Name;
                        if (name.Equals("modify_time_$n"))
                        {
                            var cs = p.GetCustomAttributes<JsonConverterAttribute>(inherit: true);
                        }

                        return new InnerTypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            propertyIsNArray: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass,
                            jsonConverter: GetTypedJsonConverter(p)
                        );
                    })
                    .OrderBy(e => e.PropertyInfo.GetCustomAttribute<JsonPropertyOrderAttribute>(inherit: true)?.Order)
                    .ToArray();
                _mappedTypeJsonProperties[mappedTypeKey] = typedJsonProperties;
            }

            return typedJsonProperties;
        }

        private static bool CheckTypeIsSubclassOf(Type type, Type generic)
        {
            bool IsTheRawGenericType(Type test)
                => generic == (test.IsGenericType ? test.GetGenericTypeDefinition() : test);

            bool isTheRawGenericType = type.GetInterfaces().Any(IsTheRawGenericType);
            if (isTheRawGenericType) 
                return true;

            while (type != null && type != typeof(object))
            {
                isTheRawGenericType = IsTheRawGenericType(type);
                if (isTheRawGenericType) return true;
                type = type.BaseType;
            }

            return false;
        }

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

        private static object CreateOrUpdateNArrayElement(Array array, int index, string jKey, JsonElement jValue, JsonSerializerOptions serializerOptions)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            object? element = array.GetValue(index);
            Type elementType = array.GetType().GetElementType()!;

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

                array.SetValue(element, index);
            }

            InnerTypedJsonProperty? typedJsonProperty = GetTypedJsonProperties(elementType)
                .SingleOrDefault(p => string.Equals(p.PropertyName.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, index.ToString()), jKey));
            if (typedJsonProperty != null)
            {
                if (typedJsonProperty.JsonConverter != null)
                {
                    serializerOptions = new JsonSerializerOptions(serializerOptions);
                    serializerOptions.Converters.Add(typedJsonProperty.JsonConverter);
                }

                object? obj = JsonSerializer.Deserialize(jValue, typedJsonProperty.PropertyType, serializerOptions)!;
                typedJsonProperty.PropertyInfo.SetValue(element, obj);
            }

            return element!;
        }
    }
}
