using System;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal abstract partial class AbstractObjectIsJsonConverter<T> : JsonConverter<T?>
        where T : class
    {
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
            else if (reader.TokenType == JsonToken.String)
            {
                string? value = serializer.Deserialize<string>(reader);
                if (value == null)
                    return existingValue;

                return JsonConvert.DeserializeObject<T>(value);
            }

            throw new JsonSerializationException();
        }

        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(JsonConvert.SerializeObject(value, serializer.Converters.ToArray()));
            else
                writer.WriteNull();
        }
    }
}
