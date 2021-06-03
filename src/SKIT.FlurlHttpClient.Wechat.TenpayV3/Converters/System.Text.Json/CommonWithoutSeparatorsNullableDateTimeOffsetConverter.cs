using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class CommonWithoutSeparatorsNullableDateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
    {
        private const string DATETIME_FORMAT = Newtonsoft.Json.Converters.CommonWithoutSeparatorsNullableDateTimeOffsetConverter.DATETIME_FORMAT;

        public override DateTimeOffset? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value == null)
                    return null;

                if (DateTimeOffset.TryParseExact(value, DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTimeOffset result))
                    return result;

                if (DateTimeOffset.TryParse(value, out result))
                    return result;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value.ToString(DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo));
            else
                writer.WriteNullValue();
        }
    }
}
