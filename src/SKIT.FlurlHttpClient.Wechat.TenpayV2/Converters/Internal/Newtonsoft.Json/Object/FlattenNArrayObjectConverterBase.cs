using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
    internal static class FlattenNArrayObjectConverterBase
    {
        public const string PROPERTY_WILDCARD_NARRAY_ELEMENT = "$n";
        public const string PROPERTY_NAME_NARRAY = "#n";
    }

    internal abstract partial class FlattenNArrayObjectConverterBase<T> : JsonConverter<T?>
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

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                InnerTypedJsonProperty[] typedJsonProperties = GetTypedJsonProperties(objectType);
                if (typedJsonProperties.Count(p => p.PropertyIsNArray) != 1)
                    throw new JsonSerializationException("The number of `$n` properties must be only one.");

                JObject jObject = JObject.Load(reader);
                T tObject = new T();

                foreach (JProperty jKey in jObject.Properties())
                {
                    InnerTypedJsonProperty? typedJsonProperty = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jKey.Name);
                    if (typedJsonProperty != null)
                    {
                        // 处理普通属性
                        JsonSerializer tmpSerializer = serializer;
                        if (typedJsonProperty.JsonConverter != null)
                        {
                            tmpSerializer = JsonSerializer.CreateDefault(serializer.ExtractSerializerSettings());
                            tmpSerializer.Converters.Add(typedJsonProperty.JsonConverter);
                        }

                        object? value = jObject[typedJsonProperty.PropertyName]?.ToObject(typedJsonProperty.PropertyType, tmpSerializer);
                        typedJsonProperty.PropertyInfo.SetValue(tObject, value);
                    }
                    else if (TryMatchNArrayIndex(jKey.Name, out int index))
                    {
                        // 处理 $n 属性
                        InnerTypedJsonProperty narrayJsonProperty = typedJsonProperties.Single(e => e.PropertyIsNArray);
                        object? value = narrayJsonProperty.PropertyInfo.GetValue(tObject);

                        JsonSerializer tmpSerializer = serializer;

                        Array array = CreateOrExpandNArray(value, narrayJsonProperty.PropertyType.GetElementType()!, index + 1);
                        object? element = CreateOrUpdateNArrayElement(array, index, jKey.Name, jKey.Value, tmpSerializer);
                        narrayJsonProperty.PropertyInfo.SetValue(tObject, array);
                    }
                    else if (serializer.MissingMemberHandling == MissingMemberHandling.Error)
                    {
                        throw new JsonSerializationException($"Could not find member `{jKey.Name}` on object of type `{objectType.Name}`.");
                    }
                }

                return tObject;
            }

            throw new JsonSerializationException();
        }

        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteStartObject();

            JsonObjectContract jsonContract = (JsonObjectContract)serializer.ContractResolver.ResolveContract(value.GetType());
            foreach (JsonProperty jsonProperty in jsonContract.Properties)
            {
                if (jsonProperty.Ignored)
                    continue;
                if (!(jsonProperty.ShouldSerialize == null || jsonProperty.ShouldSerialize(value)))
                    continue;

                string propertyKey = jsonProperty.PropertyName;
                object? propertyValue = jsonProperty.ValueProvider.GetValue(value);
                if (propertyValue is null)
                {
                    if (serializer.NullValueHandling == NullValueHandling.Ignore)
                        continue;
                }

                if (!PROPERTY_NAME_NARRAY.Equals(propertyKey))
                {
                    // 处理普通属性
                    writer.WritePropertyName(propertyKey);

                    if (jsonProperty.Converter != null && jsonProperty.Converter.CanWrite)
                    {
                        jsonProperty.Converter.WriteJson(writer, propertyValue, serializer);
                    }
                    else
                    {
                        serializer.Serialize(writer, propertyValue);
                    }
                }
                else
                {
                    // 处理 $n 属性
                    if (propertyValue is null)
                        continue;

                    JArray jArray = JArray.FromObject(propertyValue);
                    for (int i = 0, len = jArray.Count; i < len; i++)
                    {
                        JToken? jSubToken = jArray[i];
                        if (jSubToken == null)
                            continue;

                        foreach (JProperty jSubKey in jSubToken)
                        {
                            writer.WritePropertyName(jSubKey.Name.Replace(PROPERTY_WILDCARD_NARRAY_ELEMENT, i.ToString()));
                            serializer.Serialize(writer, jSubKey.Value);
                        }
                    }
                }
            }

            writer.WriteEndObject();
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
                        if (p.CanWrite || p.GetCustomAttributes<JsonPropertyAttribute>(inherit: true).Any())
                        {
                            return !p.GetCustomAttributes<JsonIgnoreAttribute>(inherit: false).Any();
                        }

                        return false;
                    })
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                        JsonConverter? converter = p.GetCustomAttributes<JsonConverterAttribute>(inherit: true)
                            .OrderByDescending(attr => attr.IsDefaultAttribute())
                            .Select(attr => (JsonConverter)Activator.CreateInstance(attr.ConverterType, attr.ConverterParameters)!)
                            .FirstOrDefault();
                        return new InnerTypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            propertyIsNArray: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass,
                            jsonConverter: converter
                        );
                    })
                    .OrderBy(e => e.PropertyInfo.GetCustomAttribute<JsonPropertyAttribute>(inherit: true)?.Order)
                    .ToArray();
                _mappedTypeJsonProperties[mappedTypeKey] = typedJsonProperties;
            }

            return typedJsonProperties;
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

        private static object CreateOrUpdateNArrayElement(Array array, int index, string jKey, JToken? jValue, JsonSerializer serializer)
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
                    serializer = JsonSerializer.CreateDefault(serializer.ExtractSerializerSettings());
                    serializer.Converters.Add(typedJsonProperty.JsonConverter);
                }

                object? obj = jValue?.ToObject(typedJsonProperty.PropertyType, serializer);
                typedJsonProperty.PropertyInfo.SetValue(element, obj);
            }

            return element!;
        }
    }
}
