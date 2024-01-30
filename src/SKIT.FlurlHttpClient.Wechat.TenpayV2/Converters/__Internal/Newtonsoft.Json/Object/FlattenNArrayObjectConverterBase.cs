using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters.Common;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities;

    internal static class FlattenNArrayObjectConverterBase
    {
        public const string PROPERTY_WILDCARD_NARRAY_ELEMENT = "$n";
        public const string PROPERTY_NAME_NARRAY = "#n";
    }

    internal abstract partial class FlattenNArrayObjectConverterBase<T> : JsonConverter
        where T : class, new()
    {
        private sealed class InnerTypedJsonPropertyInfo
        {
            public string PropertyName { get; }

            public PropertyInfo PropertyInfo { get; }

            public Type PropertyType { get { return PropertyInfo.PropertyType; } }

            public bool PropertyIsNArray { get; }

            public JsonConverter? JsonConverterOnRead { get; }

            public JsonConverter? JsonConverterOnWrite { get; }

            public InnerTypedJsonPropertyInfo(string propertyName, PropertyInfo propertyInfo, bool propertyIsNArray, JsonConverter? jsonReadConverter, JsonConverter? jsonWriteConverter)
            {
                PropertyName = propertyName;
                PropertyInfo = propertyInfo;
                PropertyIsNArray = propertyIsNArray;
                JsonConverterOnRead = jsonReadConverter;
                JsonConverterOnWrite = jsonWriteConverter;
            }
        }

        private const string PROPERTY_WILDCARD_NARRAY_ELEMENT = FlattenNArrayObjectConverterBase.PROPERTY_WILDCARD_NARRAY_ELEMENT;
        private const string PROPERTY_NAME_NARRAY = FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY;

        private static readonly Hashtable _mappedTypeJsonProperties = new Hashtable();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass && !objectType.IsAbstract && !objectType.IsInterface;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                JObject jObject = JObject.Load(reader);
                T tObject = existingValue as T ?? new T();

                JsonObjectContract jsonContract = (JsonObjectContract)serializer.ContractResolver.ResolveContract(typeof(T));
                foreach (JProperty jProperty in jObject.Properties())
                {
                    string propertyName = jProperty.Name!;

                    if (TryMatchNArrayIndex(propertyName, out int index))
                    {
                        InnerTypedJsonPropertyInfo[] typedJsonProperties = GetTypedJsonProperties(objectType);
                        if (typedJsonProperties.Count(p => p.PropertyIsNArray) != 1)
                            throw new JsonSerializationException("The count of `$n` properties must be only one.");

                        foreach (InnerTypedJsonPropertyInfo propertyJsonInfo in typedJsonProperties.Where(e => e.PropertyIsNArray))
                        {
                            Array? propertyValue = propertyJsonInfo.PropertyInfo.GetValue(tObject) as Array;
                            ReflectionHelper.CreateOrExpandArray(ref propertyValue, propertyJsonInfo.PropertyType.GetElementType()!, index + 1);
                            ReflectionHelper.CreateOrExpandArrayElement(propertyValue!, index, (object element) =>
                            {
                                InnerTypedJsonPropertyInfo? elementPropertyJsonInfo = GetTypedJsonProperties(element.GetType())
                                    .SingleOrDefault(p => string.Equals(p.PropertyName.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, index.ToString()), jProperty.Name));
                                if (elementPropertyJsonInfo is not null)
                                {
                                    JsonSerializer serializerCopy = JsonSerializer.Create(serializer.ExtractSerializerSettings());
                                    serializerCopy.Converters.Remove(this);

                                    if (elementPropertyJsonInfo.JsonConverterOnRead is not null)
                                        serializerCopy.Converters.Add(elementPropertyJsonInfo.JsonConverterOnRead);

                                    object? elementPropertyValue = jProperty.Value?.ToObject(elementPropertyJsonInfo.PropertyType, serializerCopy);
                                    elementPropertyJsonInfo.PropertyInfo.SetValue(element, elementPropertyValue);
                                }

                                return element;
                            });

                            propertyJsonInfo.PropertyInfo.SetValue(tObject, propertyValue);
                        }
                    }
                    else
                    {
                        JsonProperty? jsonContractProperty = jsonContract.Properties[propertyName];
                        if (jsonContractProperty is not null && jsonContractProperty.Writable)
                        {
                            JsonSerializer serializerCopy = JsonSerializer.Create(serializer.ExtractSerializerSettings());
                            serializerCopy.Converters.Remove(this);

                            if (jsonContractProperty.Converter is not null)
                                serializerCopy.Converters.Add(jsonContractProperty.Converter);

                            object? propertyValue = jProperty.Value.ToObject(jsonContractProperty.PropertyType, serializerCopy);
                            jsonContractProperty.ValueProvider!.SetValue(tObject, propertyValue);
                        }
                    }
                }

                return tObject;
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteStartObject();

            JsonObjectContract jsonContract = (JsonObjectContract)serializer.ContractResolver.ResolveContract(value.GetType());
            foreach (JsonProperty jsonContractProperty in jsonContract.Properties.OrderBy(e => e.Order))
            {
                if (jsonContractProperty.Ignored)
                    continue;
                if (!(jsonContractProperty.ShouldSerialize is null || jsonContractProperty.ShouldSerialize(value)))
                    continue;

                string propertyName = jsonContractProperty.PropertyName!;
                object? propertyValue = jsonContractProperty.ValueProvider?.GetValue(value);
                if (propertyValue is null)
                {
                    if (serializer.NullValueHandling == NullValueHandling.Include)
                    {
                        writer.WritePropertyName(propertyName);
                        writer.WriteNull();
                    }

                    continue;
                }

                if (!PROPERTY_NAME_NARRAY.Equals(propertyName))
                {
                    writer.WritePropertyName(propertyName);

                    if (jsonContractProperty.Converter is not null && jsonContractProperty.Converter.CanWrite)
                    {
                        jsonContractProperty.Converter.WriteJson(writer, propertyValue, serializer);
                    }
                    else
                    {
                        serializer.Serialize(writer, propertyValue);
                    }
                }
                else
                {
                    JArray jArray = JArray.FromObject(propertyValue);
                    for (int i = 0, len = jArray.Count; i < len; i++)
                    {
                        JToken? jSubToken = jArray[i];
                        if (jSubToken is null)
                            continue;

                        foreach (JProperty jSubProperty in jSubToken)
                        {
                            writer.WritePropertyName(jSubProperty.Name.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, i.ToString()));
                            serializer.Serialize(writer, jSubProperty.Value);
                        }
                    }
                }
            }

            writer.WriteEndObject();
        }

        private static InnerTypedJsonPropertyInfo[] GetTypedJsonProperties(Type type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            string mappedKey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            InnerTypedJsonPropertyInfo[]? mappedValue = (InnerTypedJsonPropertyInfo[]?)_mappedTypeJsonProperties[mappedKey];

            if (mappedValue is null)
            {
                mappedValue = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p =>
                    {
                        if (p.CanWrite || p.GetCustomAttributes<JsonPropertyAttribute>(inherit: true).Any())
                        {
                            return !p.GetCustomAttributes<JsonIgnoreAttribute>(inherit: false).Any();
                        }

                        return false;
                    })
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                        IEnumerable<JsonConverter> converters = p.GetCustomAttributes<JsonConverterAttribute>(inherit: true)
                            .OrderByDescending(attr => attr.IsDefaultAttribute())
                            .Select(attr => (JsonConverter)Activator.CreateInstance(attr.ConverterType, attr.ConverterParameters)!);
                        JsonConverter? readConverter = converters.FirstOrDefault(c => c.CanRead);
                        JsonConverter? writeConverter = converters.FirstOrDefault(c => c.CanWrite);
                        return new InnerTypedJsonPropertyInfo
                        (
                            propertyName: name,
                            propertyInfo: p,
                            propertyIsNArray: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass,
                            jsonReadConverter: readConverter,
                            jsonWriteConverter: writeConverter
                        );
                    })
                    .OrderBy(e => e.PropertyInfo.GetCustomAttribute<JsonPropertyAttribute>(inherit: true)?.Order)
                    .ToArray();
                _mappedTypeJsonProperties[mappedKey] = mappedValue;
            }

            return mappedValue;
        }

        private static bool TryMatchNArrayIndex(string key, out int index)
        {
            Regex regex = new Regex(@"(_)(\d+)$", RegexOptions.Compiled);
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
