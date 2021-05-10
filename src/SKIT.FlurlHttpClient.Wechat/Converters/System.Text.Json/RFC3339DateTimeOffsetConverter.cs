using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class RFC3339DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        private readonly JsonConverter<DateTimeOffset?> _converter = new RFC3339NullableDateTimeOffsetConverter();

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options) ?? default;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value, options);
        }
    }
}
