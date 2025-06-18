namespace System.Text.Json.Serialization.Internal
{
    internal sealed partial class YesOrNoBooleanConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(bool) == typeToConvert ||
                   typeof(bool?) == typeToConvert;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeof(bool) == typeToConvert)
                return new InternalYesOrNoBooleanConverter();
            if (typeof(bool?) == typeToConvert)
                return new InternalYesOrNoNullableBooleanConverter();

            throw new NotSupportedException();
        }
    }

    partial class YesOrNoBooleanConverter
    {
        private sealed class InternalYesOrNoNullableBooleanConverter : JsonConverter<bool?>
        {
            private const string TRUE_VALUE = "Y";
            private const string FALSE_VALUE = "N";

            public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }
                else if (reader.TokenType == JsonTokenType.True)
                {
                    return true;
                }
                else if (reader.TokenType == JsonTokenType.False)
                {
                    return false;
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    string? value = reader.GetString();
                    if (string.IsNullOrEmpty(value))
                        return null;

                    if (TRUE_VALUE.Equals(value))
                        return true;
                    else if (FALSE_VALUE.Equals(value))
                        return false;

                    throw new JsonException($"Could not parse String '{value}' to Boolean.");
                }

                throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
            }

            public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
            {
                if (value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    writer.WriteStringValue(value.Value ? TRUE_VALUE : FALSE_VALUE);
                }
            }

            public override bool? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string propName = reader.GetString()!;
                if (string.IsNullOrEmpty(propName))
                    return null;

                if (int.TryParse(propName, out int result))
                    return Convert.ToBoolean(result);

                throw new JsonException($"Could not parse String '{propName}' to Int32.");
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
            {
                if (value is null)
                    writer.WritePropertyName(string.Empty);
                else
                    writer.WritePropertyName(value.Value ? TRUE_VALUE.ToString() : FALSE_VALUE.ToString());
            }
        }

        private sealed class InternalYesOrNoBooleanConverter : JsonConverter<bool>
        {
            private readonly JsonConverter<bool?> _converter = new InternalYesOrNoNullableBooleanConverter();

            public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                bool? result = _converter.Read(ref reader, typeToConvert, options);
                return result.GetValueOrDefault();
            }

            public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value, options);
            }

            public override bool ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                bool? result = _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
                return result.GetValueOrDefault();
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
            {
                _converter.WriteAsPropertyName(writer, value, options);
            }
        }
    }
}
