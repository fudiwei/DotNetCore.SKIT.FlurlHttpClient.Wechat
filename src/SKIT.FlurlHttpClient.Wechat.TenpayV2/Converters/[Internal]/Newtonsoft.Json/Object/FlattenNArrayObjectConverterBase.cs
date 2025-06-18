using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters.Internal
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities;

    internal abstract class FlattenNArrayObjectConverterBase<TModelContainer, TFlattenElement> : JsonConverter
        where TModelContainer : class, new()
        where TFlattenElement: class, new()
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

        private static JsonObjectContract ResolveJsonType(Type type, JsonSerializer serializer)
        {
            IContractResolver resolver = serializer.ContractResolver ?? JsonSerializer.CreateDefault().ContractResolver;
            return (JsonObjectContract)resolver.ResolveContract(type);
        }

        /// <summary>
        /// 获取 `<see cref="TModelContainer"/>` 类下需要扁平展开的属性，该属性需是一个数组类型、其中每个元素是一个 `<see cref="TFlattenElement"/>`。
        /// </summary>
        protected abstract PropertyInfo FlattenProperty { get; }

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
            if (!FlattenProperty.PropertyType.IsArray)
                throw new NotSupportedException();

            return objectType.IsClass && !objectType.IsAbstract && !objectType.IsInterface
                && typeof(TModelContainer).IsAssignableFrom(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                TModelContainer outputObj = existingValue as TModelContainer ?? ReflectionHelper.CreateInstance<TModelContainer>();

                // 读取为 JObject
                JObject jObject = JObject.Load(reader);
                if (!jObject.Properties().Any())
                    return outputObj;

                // 取得下标最大值（-1 表示无需扁平展开）
                int maxIndex = jObject.Properties().Select(e => TryMatchNArrayIndex(e.Name!, out int index) ? index : -1).Max();

                // 解析 JSON 结构
                JsonObjectContract jsonContract = ResolveJsonType(objectType, serializer);

                // 遍历 JObject 并反序列化
                foreach (JProperty jProp in jObject.Properties())
                {
                    string propertyName = jProp.Name!;

                    if (maxIndex != -1 && TryMatchNArrayIndex(propertyName, out int index))
                    {
                        // 反序列化需扁平展开的字段
                        JsonObjectContract flattenJsonContract = ResolveJsonType(FlattenProperty.PropertyType.GetElementType()!, serializer);
                        JsonProperty? jsonProperty = flattenJsonContract.Properties.FirstOrDefault(e => propertyName == e.PropertyName?.Replace("$n", index.ToString()));
                        if (jsonProperty is null)
                        {
                            if (serializer.MissingMemberHandling == MissingMemberHandling.Error)
                                throw new JsonException($"Could not find member '{propertyName}' on object of type '{objectType.FullName}'");
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

                            if (jsonProperty.ShouldDeserialize is not null && !jsonProperty.ShouldDeserialize(array))
                                continue;
                            if (!jsonProperty.Writable)
                                continue;

                            object? elementPropertyValue = jProp.Value?.ToObject(jsonProperty.PropertyType, CopyJsonSerializer(serializer, jsonProperty.Converter));
                            jsonProperty.ValueProvider!.SetValue(element, elementPropertyValue);
                        }
                    }
                    else
                    {
                        JsonProperty? jsonProperty = jsonContract.Properties.GetClosestMatchProperty(propertyName);
                        // 反序列化普通字段
                        if (jsonProperty is not null)
                        {
                            if (jsonProperty.Ignored && jsonProperty.PropertyName is null)
                                continue;
                            if (jsonProperty.ShouldDeserialize is not null && !jsonProperty.ShouldDeserialize(outputObj))
                                continue;
                            if (!jsonProperty.Writable)
                                continue;

                            object? propertyValue = jProp.Value?.ToObject(jsonProperty.PropertyType, CopyJsonSerializer(serializer, jsonProperty.Converter));
                            jsonProperty.ValueProvider!.SetValue(outputObj, propertyValue);
                        }
                        // 反序列化扩展字段
                        else if (jsonContract.ExtensionDataSetter is not null)
                        {
                            throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
                        }
                    }
                }

                return outputObj;
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void WriteJson(JsonWriter writer, object? inputObj, JsonSerializer serializer)
        {
            if (inputObj is null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteStartObject();

            // 解析 JSON 结构
            JsonObjectContract jsonContract = ResolveJsonType(inputObj.GetType(), serializer);

            // 序列化普通字段
            foreach (JsonProperty jsonProperty in jsonContract.Properties.OrderBy(e => e.Order))
            {
                if (jsonProperty.Ignored && jsonProperty.PropertyName is null)
                    continue;
                if (jsonProperty.ShouldSerialize is not null && !jsonProperty.ShouldSerialize(inputObj))
                    continue;
                if (!jsonProperty.Readable)
                    continue;

                string propertyName = jsonProperty.PropertyName ?? jsonProperty.UnderlyingName!;
                if (FLATTEN_PROPERTY_JSON_NAME.Equals(propertyName))
                {
                    if (jsonProperty.PropertyType != FlattenProperty.PropertyType)
                        throw new JsonException("Ambiguous flatten property found.");

                    continue;
                }

                object? propertyValue = jsonProperty.ValueProvider?.GetValue(inputObj);
                if (propertyValue is null)
                {
                    if (serializer.NullValueHandling == NullValueHandling.Include)
                    {
                        writer.WritePropertyName(propertyName);
                        writer.WriteNull();
                    }
                }
                else
                {
                    writer.WritePropertyName(propertyName);

                    if (jsonProperty.Converter is not null && jsonProperty.Converter.CanWrite)
                        jsonProperty.Converter.WriteJson(writer, propertyValue, serializer);
                    else
                        serializer.Serialize(writer, propertyValue);
                }
            }

            // 序列化扩展字段
            if (jsonContract.ExtensionDataGetter is not null)
            {
                throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
            }

            // 序列化需扁平展开的字段
            Array? flattenArray = ReflectionHelper.GetPropertyValue<Array>(inputObj, FlattenProperty);
            if (flattenArray is not null)
            {
                int index = 0;
                foreach (JToken jToken in JArray.FromObject(flattenArray))
                {
                    if (jToken.Type != JTokenType.Null)
                    {
                        foreach (JProperty jProp in jToken)
                        {
                            string propertyName = jProp.Name.Replace("$n", index.ToString());
                            if (jProp.Value is null || jProp.Value.Type == JTokenType.Null)
                            {
                                if (serializer.NullValueHandling == NullValueHandling.Include)
                                {
                                    writer.WritePropertyName(propertyName);
                                    writer.WriteNull();
                                }
                            }
                            else
                            {
                                writer.WritePropertyName(propertyName);
                                serializer.Serialize(writer, jProp.Value);
                            }
                        }
                    }

                    index++;
                }
            }

            writer.WriteEndObject();
        }

        private JsonSerializer CopyJsonSerializer(JsonSerializer serializer, params JsonConverter?[] customConverters)
        {
            JsonSerializer serializerCopy = JsonSerializer.Create(serializer.ExtractSerializerSettings());
            serializerCopy.Converters.Remove(this);

            foreach (JsonConverter? converter in customConverters)
            {
                if (converter is not null)
                    serializerCopy.Converters.Add(converter);
            }

            return serializerCopy;
        }
    }
}
