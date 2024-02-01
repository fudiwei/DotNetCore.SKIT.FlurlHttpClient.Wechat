using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace System.Text.Json.Serialization.Internal
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities;

    internal abstract partial class FlattenNArrayObjectConverterBase<TModelContainer, TFlattenElement> : JsonConverter<TModelContainer?>
        where TModelContainer : class, new()
        where TFlattenElement : class, new()
    {
        public const string FLATTEN_PROPERTY_JSON_NAME = "#n";
        
        private static bool TryMatchNArrayIndex(string key, out int index)
        {
            Regex regex = new Regex(@"_(\d+)$", RegexOptions.Compiled);
            if (regex.IsMatch(key))
            {
                string str = regex.Match(key).Groups[1].Value;
                index = int.Parse(str);
                return true;
            }

            index = -1;
            return false;
        }

        /// <summary>
        /// 获取 `<see cref="TModelContainer"/>` 类下需要扁平展开的属性，该属性需是一个数组类型、其中每个元素是一个 `<see cref="TFlattenElement"/>`。
        /// </summary>
        protected abstract PropertyInfo FlattenProperty { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            if (!FlattenProperty.PropertyType.IsArray)
                throw new NotSupportedException();

            return typeToConvert.IsClass && !typeToConvert.IsAbstract && !typeToConvert.IsInterface
                && typeof(TModelContainer).IsAssignableFrom(typeToConvert);
        }

        public override TModelContainer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                TModelContainer outputObj = ReflectionHelper.CreateInstance<TModelContainer>();

                // 读取为 JsonObject
                JsonObject jObject = JsonObject.Parse(ref reader, new JsonNodeOptions() { PropertyNameCaseInsensitive = options.PropertyNameCaseInsensitive })!.AsObject();
                if (!jObject.Any())
                    return outputObj;

                // 取得下标最大值（-1 表示无需扁平展开）
                int maxIndex = jObject.Select(e => TryMatchNArrayIndex(e.Key, out int index) ? index : -1).Max();

                // 解析 JSON 结构
                JsonPropertyTypeInfo[] jsonPropertyTypes = JsonPropertyTypeInfoCache.GetOrAddJsonPropertyTypes(typeToConvert, options);

                // 遍历 JsonObject 并反序列化
                foreach (KeyValuePair<string, JsonNode?> jProp in jObject)
                {
                    string propertyName = jProp.Key;

                    if (maxIndex != -1 && TryMatchNArrayIndex(propertyName, out int index))
                    {
                        // 反序列化需扁平展开的字段
                        JsonPropertyTypeInfo[] flattenJsonPropertyTypes = JsonPropertyTypeInfoCache.GetOrAddJsonPropertyTypes(FlattenProperty.PropertyType.GetElementType()!, options);
                        JsonPropertyTypeInfo? jsonPropertyType = flattenJsonPropertyTypes.FirstOrDefault(e => propertyName == e.JsonPropertyName.Replace("$n", index.ToString()));
                        if (jsonPropertyType is null)
                        {
                            if (options.UnmappedMemberHandling == JsonUnmappedMemberHandling.Disallow)
                                throw new JsonException($"The JSON property '{propertyName}' could not be mapped to any .NET member contained in type '{typeToConvert.FullName}'");
                        }
                        else
                        {
                            Array? array = ReflectionHelper.GetPropertyValue<Array>(outputObj, FlattenProperty);
                            if (array is null)
                            {
                                array = new TFlattenElement[maxIndex + 1];
                                ReflectionHelper.SetPropertyValue(outputObj, FlattenProperty, array);
                            }

                            TFlattenElement? element = ReflectionHelper.GetElementValue<TFlattenElement>(array, index);
                            if (element is null)
                            {
                                element = ReflectionHelper.CreateInstance<TFlattenElement>();
                                ReflectionHelper.SetElementValue(array, index, element);
                            }

                            object? elementPropertyValue = jProp.Value?.Deserialize(jsonPropertyType.PropertyType, CopyJsonSerializerOptions(options, jsonPropertyType.JsonConverter));
                            ReflectionHelper.SetPropertyValue(element, jsonPropertyType.Property, elementPropertyValue);
                        }
                    }
                    else
                    {
                        JsonPropertyTypeInfo? jsonPropertyType = jsonPropertyTypes.FirstOrDefault(e => propertyName == e.JsonPropertyName);
                        if (jsonPropertyType is null && options.PropertyNameCaseInsensitive)
                            jsonPropertyType = jsonPropertyTypes.FirstOrDefault(e => string.Equals(propertyName, e.JsonPropertyName, StringComparison.OrdinalIgnoreCase));

                        // 反序列化普通字段
                        if (jsonPropertyType is not null)
                        {
                            object? propertyValue = jProp.Value?.Deserialize(jsonPropertyType.PropertyType, CopyJsonSerializerOptions(options, jsonPropertyType.JsonConverter));
                            ReflectionHelper.SetPropertyValue(outputObj, jsonPropertyType.Property, propertyValue);
                        }
                        // 反序列化扩展字段
                        else if (jsonPropertyTypes.Any(e => e.IsExtensionData))
                        {
                            throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
                        }
                    }
                }

                return outputObj;
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void Write(Utf8JsonWriter writer, TModelContainer? inputObj, JsonSerializerOptions options)
        {
            if (inputObj is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();

            // 解析 JSON 结构
            JsonPropertyTypeInfo[] jsonPropertyTypes = JsonPropertyTypeInfoCache.GetOrAddJsonPropertyTypes(inputObj.GetType(), options);

            // 序列化普通字段
            foreach (JsonPropertyTypeInfo jsonPropertyType in jsonPropertyTypes)
            {
                if (jsonPropertyType.IsExtensionData)
                    continue;

                string propertyName = jsonPropertyType.JsonPropertyName;
                if (FLATTEN_PROPERTY_JSON_NAME.Equals(propertyName))
                {
                    if (jsonPropertyType.Property != FlattenProperty)
                        throw new JsonException("Ambiguous flatten property found.");

                    continue;
                }

                object? propertyValue = ReflectionHelper.GetPropertyValue<object>(inputObj, jsonPropertyType.Property);
                if (propertyValue is null)
                {
                    if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingNull)
                        continue;
                }
                else if (propertyValue == (jsonPropertyType.PropertyType.IsValueType ? ReflectionHelper.CreateInstance<TFlattenElement>() : null))
                {
                    if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingDefault)
                        continue;
                }

                writer.WritePropertyName(options.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);
                writer.WriteRawValue(JsonSerializer.Serialize(propertyValue, CopyJsonSerializerOptions(options, jsonPropertyType.JsonConverter)), skipInputValidation: true);
            }

            // 序列化扩展字段
            if (jsonPropertyTypes.Any(e => e.IsExtensionData))
            {
                throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
            }

            // 序列化需扁平展开的字段
            Array? flattenArray = ReflectionHelper.GetPropertyValue<Array>(inputObj, FlattenProperty);
            if (flattenArray is not null)
            {
                for (int index = 0; index < flattenArray.Length; index++)
                {
                    object? element = ReflectionHelper.GetElementValue<object>(flattenArray, index);
                    if (element is null)
                        continue;

                    JsonObject jObject = JsonSerializer.SerializeToNode(element, CopyJsonSerializerOptions(options))!.AsObject();
                    foreach (KeyValuePair<string, JsonNode?> jProp in jObject)
                    {
                        string propertyName = jProp.Key.Replace("$n", index.ToString());
                        JsonNode? propertyValueNode = jProp.Value;
                        if (propertyValueNode is null || propertyValueNode.GetValueKind() == JsonValueKind.Null)
                        {
                            if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Never)
                            {
                                writer.WritePropertyName(options.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);
                                writer.WriteNullValue();
                            }
                        }
                        else
                        {
                            writer.WritePropertyName(options.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);
                            writer.WriteRawValue(propertyValueNode?.ToJsonString(options)!, skipInputValidation: true);
                        }
                    }
                }
            }

            writer.WriteEndObject();
        }

        private JsonSerializerOptions CopyJsonSerializerOptions(JsonSerializerOptions options, params JsonConverter?[] customConverters)
        {
            JsonSerializerOptions optionsCopy = new JsonSerializerOptions(options);
            optionsCopy.Converters.Remove(this);

            foreach (JsonConverter? converter in customConverters)
            {
                if (converter is not null)
                    optionsCopy.Converters.Add(converter);
            }

            return optionsCopy;
        }
    }

    partial class FlattenNArrayObjectConverterBase<TModelContainer, TFlattenElement>
    {
        private class JsonPropertyTypeInfo
        {
            public PropertyInfo Property { get; }

            public Type PropertyType { get { return Property.PropertyType; } }

            public JsonIgnoreCondition JsonIgnoreCondition { get; }

            public JsonConverter? JsonConverter { get; }

            public string JsonPropertyName { get; }

            public int? JsonPropertyOrder { get; }

            public bool IsExtensionData { get; }

            public JsonPropertyTypeInfo(PropertyInfo property, JsonIgnoreCondition jsonIgnoreCondition, JsonConverter? jsonConverter, string jsonPropertyName, int? jsonPropertyOrder)
            {
                Property = property ?? throw new ArgumentNullException(nameof(property));
                JsonIgnoreCondition = jsonIgnoreCondition;
                JsonConverter = jsonConverter;
                JsonPropertyName = jsonPropertyName;
                JsonPropertyOrder = jsonPropertyOrder;
                IsExtensionData = property.IsDefined(typeof(JsonExtensionDataAttribute), inherit: true);
            }
        }

        private static class JsonPropertyTypeInfoCache
        {
            private static readonly Hashtable _cache = new Hashtable(capacity: 32);

            private static Type[] GetSortedTypeHierarchy(Type type)
            {
                if (!type.IsInterface)
                {
                    IList<Type> results = new List<Type>();
                    for (Type? current = type; current is not null; current = current.BaseType)
                    {
                        results.Add(current);
                    }

                    return results.ToArray();
                }
                else
                {
                    throw new NotSupportedException();
                }
            }

            private static PropertyInfo[] GetSerializableProperties(Type typeToConvert)
            {
                IList<PropertyInfo> results = new List<PropertyInfo>();

                foreach (PropertyInfo propertyInfo in typeToConvert.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (propertyInfo.GetIndexParameters().Length > 0 ||
                       (propertyInfo.GetMethod?.IsAbstract == true || propertyInfo.SetMethod?.IsAbstract == true))
                    {
                        continue;
                    }

                    bool hasJsonIncludeAttribute = propertyInfo.GetCustomAttribute<JsonIncludeAttribute>(inherit: false) is not null;
                    if (propertyInfo.GetMethod?.IsPublic == true ||
                        propertyInfo.SetMethod?.IsPublic == true ||
                        hasJsonIncludeAttribute)
                    {
                        results.Add(propertyInfo);
                    }
                }

                return results.ToArray();
            }

            private static JsonIgnoreCondition GetPropertyJsonIgnoreCondition(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonIgnoreAttribute? ignoreAttribute = propertyInfo.GetCustomAttribute<JsonIgnoreAttribute>(inherit: false);
                if (ignoreAttribute is not null)
                    return ignoreAttribute.Condition;

                return jsonSerializerOptions.DefaultIgnoreCondition;
            }

            private static JsonConverter? GetPropertyJsonConverter(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonConverterAttribute? converterAttribute = propertyInfo.GetCustomAttribute<JsonConverterAttribute>(inherit: false);
                if (converterAttribute is null)
                    return null;

                Type? converterType = converterAttribute.ConverterType;
                if (converterType is null)
                    return converterAttribute.CreateConverter(propertyInfo.PropertyType)
                        ?? converterAttribute.CreateConverter(propertyInfo.ReflectedType ?? propertyInfo.DeclaringType!)
                        ?? jsonSerializerOptions.GetConverter(propertyInfo.PropertyType);
                else
                    return (JsonConverter)Activator.CreateInstance(converterType)!;
            }

            private static int? GetPropertyJsonOrder(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonPropertyOrderAttribute? orderAttribute = propertyInfo.GetCustomAttribute<JsonPropertyOrderAttribute>(inherit: true);
                if (orderAttribute is not null)
                    return orderAttribute.Order;

                return null;
            }

            private static string GetPropertyJsonName(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonPropertyNameAttribute? nameAttribute = propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>(inherit: true);
                if (nameAttribute is not null)
                    return nameAttribute.Name;
                else if (jsonSerializerOptions.PropertyNamingPolicy is not null)
                    return jsonSerializerOptions.PropertyNamingPolicy.ConvertName(propertyInfo.Name);
                else
                    return propertyInfo.Name;
            }

            public static JsonPropertyTypeInfo[] GetOrAddJsonPropertyTypes(Type typeToConvert, JsonSerializerOptions options)
            {
                JsonPropertyTypeInfo[]? results = _cache[typeToConvert] as JsonPropertyTypeInfo[];

                if (results is null)
                {
                    IList<JsonPropertyTypeInfo> temp = new List<JsonPropertyTypeInfo>();

                    foreach (Type currentType in GetSortedTypeHierarchy(typeToConvert))
                    {
                        if (currentType == typeof(Object) ||
                            currentType == typeof(ValueType))
                        {
                            break;
                        }

                        foreach (PropertyInfo propertyInfo in GetSerializableProperties(typeToConvert))
                        {
                            JsonIgnoreCondition jsonIgnoreCondition = GetPropertyJsonIgnoreCondition(propertyInfo, options);
                            JsonConverter? jsonConverter = GetPropertyJsonConverter(propertyInfo, options);
                            string jsonPropertyName = GetPropertyJsonName(propertyInfo, options);
                            int? jsonPropertyOrder = GetPropertyJsonOrder(propertyInfo, options);

                            if (!temp.Any(e => e.JsonPropertyName == jsonPropertyName))
                                temp.Add(new JsonPropertyTypeInfo(property: propertyInfo, jsonIgnoreCondition: jsonIgnoreCondition, jsonConverter: jsonConverter, jsonPropertyName: jsonPropertyName, jsonPropertyOrder: jsonPropertyOrder));
                        }
                    }

                    results = temp.OrderBy(e => e.JsonPropertyOrder).ToArray();
                    _cache[typeToConvert] = results;
                }

                return results;
            }
        }
    }
}
