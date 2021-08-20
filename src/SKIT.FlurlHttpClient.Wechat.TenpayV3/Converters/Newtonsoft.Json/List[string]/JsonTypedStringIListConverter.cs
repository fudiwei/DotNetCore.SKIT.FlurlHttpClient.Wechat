using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    internal class JsonTypedStringIListConverter : JsonConverter<IList<string>?>
    {
        private readonly JsonConverter<List<string>?> _converter = new JsonTypedStringListConverter();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override IList<string>? ReadJson(JsonReader reader, Type objectType, IList<string>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return _converter.ReadJson(reader, objectType, ConvertIListToList(existingValue), hasExistingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, IList<string>? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, ConvertIListToList(value), serializer);
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
