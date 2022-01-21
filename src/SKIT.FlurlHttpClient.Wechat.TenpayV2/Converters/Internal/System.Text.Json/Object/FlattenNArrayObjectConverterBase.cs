using System.Collections;
using System.Linq;
using System.Reflection;
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

            public bool IsNArrayProperty { get; }

            public InnerTypedJsonProperty(string propertyName, PropertyInfo propertyInfo, bool isNArrayProperty)
            {
                PropertyName = propertyName;
                PropertyInfo = propertyInfo;
                IsNArrayProperty = isNArrayProperty;
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
                if (typedJsonProperties.Count(p => p.IsNArrayProperty) != 1)
                    throw new JsonException("The number of `$n` properties must be only one.");

                JsonElement jElement = JsonDocument.ParseValue(ref reader).RootElement.Clone();
                T tObject = new T();

                foreach (JsonProperty jKey in jElement.EnumerateObject())
                {
                    InnerTypedJsonProperty? typedJsonProperty = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jKey.Name);
                    if (typedJsonProperty != null)
                    {
                        // 处理普通属性
                        object? value = options is null ?
                            JsonSerializer.Deserialize(jKey.Value, typedJsonProperty.PropertyType, options) :
                            JsonSerializer.Deserialize(jKey.Value, typedJsonProperty.PropertyType, options);
                        typedJsonProperty.PropertyInfo.SetValue(tObject, value);
                    }
                    else if (TryMatchNArrayIndex(jKey.Name, out int index))
                    {
                        // 处理 $n 属性
                        InnerTypedJsonProperty narrayJsonProperty = typedJsonProperties.Single(e => e.IsNArrayProperty);
                        object? value = narrayJsonProperty.PropertyInfo.GetValue(tObject);

                        Array array = CreateOrExpandNArray(value, narrayJsonProperty.PropertyType.GetElementType()!, index + 1);
                        object? element = CreateOrUpdateNArrayElement(array, index, jKey.Name, jKey.Value, options);
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

            // TODO
            //throw new NotImplementedException();
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
                        (p.CanRead && !p.GetCustomAttributes<JsonIgnoreAttribute>(inherit: true).Any()) &&
                        (p.CanWrite || p.GetCustomAttributes<JsonIncludeAttribute>(inherit: true).Any())
                    )
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<JsonPropertyNameAttribute>(inherit: true)?.Name ?? p.Name;
                        return new InnerTypedJsonProperty
                        (
                            propertyName: name,
                            propertyInfo: p,
                            isNArrayProperty: PROPERTY_NAME_NARRAY.Equals(name) && p.PropertyType.IsArray && p.PropertyType.GetElementType()!.IsClass
                        );
                    })
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

        private static object CreateOrUpdateNArrayElement(Array array, int index, string jKey, JsonElement jValue, JsonSerializerOptions? serializerOptions = null)
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
                serializerOptions = (serializerOptions == null) ? new JsonSerializerOptions() : new JsonSerializerOptions(serializerOptions);
                foreach (JsonConverterAttribute attribute in typedJsonProperty.PropertyInfo.GetCustomAttributes<JsonConverterAttribute>(inherit: true))
                {
                    JsonConverter converter = (JsonConverter)Activator.CreateInstance(attribute.ConverterType!);
                    serializerOptions.Converters.Add(converter!);
                }

                object? obj = JsonSerializer.Deserialize(jValue, typedJsonProperty.PropertyType, serializerOptions)!;
                typedJsonProperty.PropertyInfo.SetValue(element, obj);
            }

            return element!;
        }
    }
}
