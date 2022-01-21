using System;

namespace Newtonsoft.Json.Converters
{
    internal class PureDigitalTextDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        private readonly JsonConverter<DateTimeOffset?> _converter = new PureDigitalTextNullableDateTimeOffsetConverter();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override DateTimeOffset ReadJson(JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return _converter.ReadJson(reader, objectType, existingValue, hasExistingValue, serializer) ?? default;
        }

        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, value, serializer);
        }
    }
}
