using System;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Converters
{
    internal abstract partial class AbstractObjectIsNArrayConverter<T> : JsonConverter<T?>
        where T : class, new()
    {
        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                JObject jObject = serializer.Deserialize<JObject>(reader);
                return SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities.JsonUtility.DeserializeWhenHasNArray<T>(ref jObject, serializer);
            }

            throw new JsonSerializationException();
        }

        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteRaw(SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities.JsonUtility.SerializeWhenHasNArray<T>(value, serializer));
            else
                writer.WriteNull();
        }
    }
}
