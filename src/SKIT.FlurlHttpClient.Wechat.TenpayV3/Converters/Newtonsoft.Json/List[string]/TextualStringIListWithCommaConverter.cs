using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualStringIListWithCommaConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            bool ret = objectType == typeof(IList<string>) || objectType == typeof(List<string>);
            if (!ret)
            {
                ret = objectType.IsGenericType &&
                      objectType.GetGenericTypeDefinition() == typeof(List<>) &&
                      objectType.GetElementType() == typeof(string);
            }
            return ret;
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? value = serializer.Deserialize<string>(reader);
                if (value == null)
                    return null;
                if (string.IsNullOrEmpty(value))
                    return new List<string>();

                return value.Split(',').ToList();
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(",", value));
            else
                writer.WriteNull();
        }
    }
}
