using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
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
                InnerTypedJsonPropertyInfo[] typedJsonProperties = GetTypedJsonProperties(objectType);
                //if (typedJsonProperties.Count(p => p.PropertyIsNArray) != 1)
                //    throw new JsonSerializationException("The count of `$n` properties must be only one.");

                JObject jObject = JObject.Load(reader);
                T tObject = new T();

                foreach (JProperty jProperty in jObject.Properties())
                {
                    InnerTypedJsonPropertyInfo? typedJsonPropertyInfo = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jProperty.Name);
                    if (typedJsonPropertyInfo != null)
                    {
                        JsonSerializer tmpSerializer = GetClonedJsonSerializer(serializer, typedJsonPropertyInfo.JsonConverterOnRead);
                        object? propertyValue = jProperty.Value?.ToObject(typedJsonPropertyInfo.PropertyType, tmpSerializer);
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
                                    JsonSerializer tmpSerializer = GetClonedJsonSerializer(serializer, insider.JsonConverterOnRead);
                                    object? elementPropertyValue = jProperty.Value?.ToObject(insider.PropertyType, tmpSerializer);
                                    insider.PropertyInfo.SetValue(element, elementPropertyValue);
                                }

                                return element;
                            });

                            typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                        }
                    }
                    else if (serializer.MissingMemberHandling == MissingMemberHandling.Error)
                    {
                        throw new JsonSerializationException($"Could not find member `{jProperty.Name}` on object of type `{objectType.Name}`.");
                    }
                }

                return tObject;
            }

            throw new JsonSerializationException();
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
            foreach (JsonProperty jsonContractProperty in jsonContract.Properties)
            {
                if (jsonContractProperty.Ignored)
                    continue;
                if (!(jsonContractProperty.ShouldSerialize == null || jsonContractProperty.ShouldSerialize(value)))
                    continue;

                string propertyName = jsonContractProperty.PropertyName!;
                object? propertyValue = jsonContractProperty.ValueProvider?.GetValue(value);
                if (propertyValue is null)
                {
                    if (serializer.NullValueHandling == NullValueHandling.Ignore)
                        continue;
                }

                if (!PROPERTY_NAME_NARRAY.Equals(propertyName))
                {
                    writer.WritePropertyName(propertyName);

                    if (jsonContractProperty.Converter != null && jsonContractProperty.Converter.CanWrite)
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
                    if (propertyValue is null)
                        continue;

                    JArray jArray = JArray.FromObject(propertyValue);
                    for (int i = 0, len = jArray.Count; i < len; i++)
                    {
                        JToken? jSubToken = jArray[i];
                        if (jSubToken == null)
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
            if (type == null) throw new ArgumentNullException(nameof(type));

            string mappedKey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            InnerTypedJsonPropertyInfo[]? mappedValue = (InnerTypedJsonPropertyInfo[]?)_mappedTypeJsonProperties[mappedKey];

            if (mappedValue == null)
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

        private static JsonSerializer GetClonedJsonSerializer(JsonSerializer serializer, JsonConverter? converter)
        {
            JsonSerializer serializerCopy = serializer;

            if (converter != null)
            {
                serializerCopy = JsonSerializer.CreateDefault(serializer.ExtractSerializerSettings());
                serializerCopy.Converters.Add(converter);
            }

            return serializerCopy;
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
