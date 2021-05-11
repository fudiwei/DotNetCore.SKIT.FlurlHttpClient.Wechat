using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class NumberTypedBooleanConverter : JsonConverter<bool>
    {
        private readonly JsonConverter<bool?> _converter = new NumberTypedNullableBooleanConverter();

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
