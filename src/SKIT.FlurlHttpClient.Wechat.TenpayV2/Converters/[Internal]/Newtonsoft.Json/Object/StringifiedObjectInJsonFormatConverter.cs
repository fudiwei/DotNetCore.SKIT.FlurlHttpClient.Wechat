using System;

namespace Newtonsoft.Json.Converters.Internal
{
    internal sealed class StringifiedObjectInJsonFormatConverter : JsonConverter
    {
        private readonly Common.StringifiedObjectInJsonFormatConverter _fallback = new Common.StringifiedObjectInJsonFormatConverter();

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
            return true;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                // NOTICE:
                //   此处读取不使用 `serializer.Deserialize<string>(reader)`，会与 FlattenNArrayObjectConverter 冲突。
                //   仅当模型被 FlattenNArrayObjectConverter 修饰时才使用此转换器；否则仍使用公共组件中提供的自定义转换器。
                string? value = reader.ReadAsString();
                if (string.IsNullOrEmpty(value))
                    return existingValue;

                return JsonConvert.DeserializeObject(value!, objectType);
            }

            return _fallback.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            _fallback.WriteJson(writer, value, serializer);
        }
    }
}
