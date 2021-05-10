using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class RFC3339NullableDateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
    {
        internal const string DATETIME_FORMAT = "yyyy-MM-dd'T'HH:mm:sszzz";

        public override bool CanRead 
        { 
            get { return true; } 
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override DateTimeOffset? ReadJson(JsonReader reader, Type objectType, DateTimeOffset? existingValue, bool hasExistingValue, JsonSerializer serializer)
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

                if (DateTimeOffset.TryParseExact(value, DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTimeOffset result))
                    return result;

                if (DateTimeOffset.TryParse(value, out result))
                    return result;
            }
            else if (reader.TokenType == JsonToken.Date)
            {
                reader.DateFormatString = DATETIME_FORMAT;
                return serializer.Deserialize<DateTimeOffset>(reader);
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, DateTimeOffset? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value.ToString(DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo));
            else
                writer.WriteNull();
        }
    }
}
