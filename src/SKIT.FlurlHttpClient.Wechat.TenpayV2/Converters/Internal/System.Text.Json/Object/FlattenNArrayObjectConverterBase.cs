using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace System.Text.Json.Converters
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities;

    internal static class FlattenNArrayObjectConverterBase
    {
        public const string PROPERTY_WILDCARD_NARRAY_ELEMENT = Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_WILDCARD_NARRAY_ELEMENT;
        public const string PROPERTY_NAME_NARRAY = Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY;
    }

    internal class FlattenNArrayObjectConverterBase<T> : JsonConverter<T?>
        where T : class, new()
    {
        private sealed class InnerTypedJsonPropertyInfo
        {
            public string PropertyName { get; }

            public PropertyInfo PropertyInfo { get; }

            public Type PropertyType { get { return PropertyInfo.PropertyType; } }

            public bool PropertyIsNArray { get; }

            public JsonConverter? JsonConverter { get; }

            public InnerTypedJsonPropertyInfo(string propertyName, PropertyInfo propertyInfo, bool propertyIsNArray, JsonConverter? jsonConverter)
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

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && !typeToConvert.IsAbstract && !typeToConvert.IsInterface;
        }

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                InnerTypedJsonPropertyInfo[] typedJsonProperties = GetTypedJsonProperties(typeToConvert);
                //if (typedJsonProperties.Count(p => p.PropertyIsNArray) != 1)
                //    throw new JsonException("The count of `$n` properties must be only one.");

                JsonElement jElement = JsonDocument.ParseValue(ref reader).RootElement.Clone();
                T tObject = new T();

                foreach (JsonProperty jProperty in jElement.EnumerateObject())
                {
                    InnerTypedJsonPropertyInfo? typedJsonPropertyInfo = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jProperty.Name);
                    if (typedJsonPropertyInfo != null)
                    {
                        JsonSerializerOptions tmpOptions = GetClonedJsonSerializerOptions(options, typedJsonPropertyInfo.JsonConverter);
                        object? propertyValue = jProperty.Value.Deserialize(typedJsonPropertyInfo.PropertyType, tmpOptions);
                        typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                    }
                    else if (TryMatchNArrayIndex(jProperty.Name, out int index))
                    {
                        foreach (var _ in typedJsonProperties.Where(e => e.PropertyIsNArray))
                        {
                            typedJsonPropertyInfo = _;

                            Array? propertyValue = typedJsonPropertyInfo.PropertyInfo.GetValue(tObject) as Array;
                            ReflectionUtility.CreateOrExpandArray(ref propertyValue, typedJsonPropertyInfo.PropertyType.GetElementType()!, index + 1);
                            ReflectionUtility.CreateOrExpandArrayElement(propertyValue!, index, (object element) =>
                            {
                                InnerTypedJsonPropertyInfo? insider = GetTypedJsonProperties(element.GetType())
                                    .SingleOrDefault(p => string.Equals(p.PropertyName.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, index.ToString()), jProperty.Name));
                                if (insider != null)
                                {
                                    JsonSerializerOptions tmpOptions = GetClonedJsonSerializerOptions(options, insider.JsonConverter);
                                    object? elementPropertyValue = JsonSerializer.Deserialize(jProperty.Value, insider.PropertyType, tmpOptions)!;
                                    insider.PropertyInfo.SetValue(element, elementPropertyValue);
                                }

                                return element;
                            });

                            typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                        }
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

            foreach (InnerTypedJsonPropertyInfo typedJsonProperty in GetTypedJsonProperties(value.GetType()))
            {
                if (!typedJsonProperty.PropertyIsNArray)
                {
                    string propertyName = typedJsonProperty.PropertyName;
                    object? propertyValue = typedJsonProperty.PropertyInfo.GetValue(value);
                    if (propertyValue is null)
                    {
                        if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingNull)
                            continue;
                    }
                    if (propertyValue == (typedJsonProperty.PropertyType.IsValueType ? Activator.CreateInstance(typedJsonProperty.PropertyType) : null))
                    {
                        if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingDefault)
                            continue;
                    }

                    JsonSerializerOptions tmpOptions = GetClonedJsonSerializerOptions(options, typedJsonProperty.JsonConverter);
                    if (typedJsonProperty.JsonConverter != null && ReflectionUtility.CheckTypeIsSubclassOf(typedJsonProperty.JsonConverter.GetType(), typeof(TextualObjectInJsonFormatConverterBase<>)))
                    {
                        // TODO: 优化
                        tmpOptions.Converters.Remove(typedJsonProperty.JsonConverter);
                        writer.WritePropertyName(tmpOptions.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);
                        writer.WriteStringValue(JsonSerializer.Serialize(propertyValue, tmpOptions));
                    }
                    else
                    {
                        writer.WritePropertyName(tmpOptions.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);
                        writer.WriteRawValue(JsonSerializer.Serialize(propertyValue, tmpOptions), skipInputValidation: true);
                    }
                }
                else
                {
                    Array? array = (Array?)typedJsonProperty.PropertyInfo.GetValue(value);
                    if (array is null)
                        continue;

                    for (int i = 0, len = array.Length; i < len; i++)
                    {
                        object? element = array.GetValue(i);
                        if (element is null)
                            continue;

                        JsonSerializerOptions tmpOptions = GetClonedJsonSerializerOptions(options, GetTypedJsonConverter(element.GetType()));
                        JsonObject jSubObject = JsonSerializer.SerializeToNode(element, tmpOptions)!.AsObject();
                        foreach (KeyValuePair<string, JsonNode?> jSubProperty in jSubObject)
                        {
                            string subPropertyName = jSubProperty.Key.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, i.ToString());
                            JsonNode? subPropertyValue = jSubProperty.Value;
                            writer.WritePropertyName(tmpOptions.PropertyNamingPolicy?.ConvertName(subPropertyName) ?? subPropertyName);
                            writer.WriteRawValue(subPropertyValue?.ToJsonString(tmpOptions)!, skipInputValidation: true);
                        }
                    }
                }
            }
            writer.WriteEndObject();
        }

        private static InnerTypedJsonPropertyInfo[] GetTypedJsonProperties(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            string mappedKey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            InnerTypedJsonPropertyInfo[]? mappedValue = (InnerTypedJsonPropertyInfo[]?)_mappedTypeJsonProperties[mappedKey];

            if (mappedValue == null)
            {
                mappedValue = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
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
                        return new InnerTypedJsonPropertyInfo
                        (
                            propertyName: name,
                            propertyInfo: p,
                            propertyIsNArray: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass,
                            jsonConverter: GetTypedJsonConverter(p)
                        );
                    })
                    .OrderBy(e => e.PropertyInfo.GetCustomAttribute<JsonPropertyOrderAttribute>(inherit: true)?.Order)
                    .ToArray();
                _mappedTypeJsonProperties[mappedKey] = mappedValue;
            }

            return mappedValue;
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

        private static JsonSerializerOptions GetClonedJsonSerializerOptions(JsonSerializerOptions options, JsonConverter? converter)
        {
            JsonSerializerOptions optionsCopy = options;

            if (converter != null)
            {
                optionsCopy = new JsonSerializerOptions(options);
                optionsCopy.Converters.Add(converter);
            }

            return optionsCopy;
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
    }
}
