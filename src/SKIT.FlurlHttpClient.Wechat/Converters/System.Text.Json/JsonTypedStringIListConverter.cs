using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class JsonTypedStringIListConverter : JsonConverter<IList<string>?>
    {
        private readonly JsonConverter<List<string>?> _converter = new JsonTypedStringListConverter();

        public override IList<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, IList<string>? value, JsonSerializerOptions options)
        {
            _converter.Write(writer, ConvertIListToList(value), options);
        }

        private List<string>? ConvertIListToList(IList<string>? src)
        {
            if (src == null)
                return null;

            List<string>? dest = src as List<string>;
            if (dest != null)
                return dest;

            return new List<string>(src);
        }
    }
}
