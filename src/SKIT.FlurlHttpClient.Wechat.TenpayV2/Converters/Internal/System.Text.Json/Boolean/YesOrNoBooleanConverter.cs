using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class YesOrNoBooleanConverter : JsonConverter<bool>
    {
        private readonly JsonConverter<bool?> _converter = new YesOrNoNullableBooleanConverter();

        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options) ?? default;
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value, options);
        }
    }
}
