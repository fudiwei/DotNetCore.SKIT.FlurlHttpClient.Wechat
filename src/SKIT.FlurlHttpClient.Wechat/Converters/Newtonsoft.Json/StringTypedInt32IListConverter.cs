using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class StringTypedInt32IListConverter : JsonConverter<IList<int>?>
    {
        private readonly JsonConverter<List<int>?> _converter = new StringTypedInt32ListConverter();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override IList<int>? ReadJson(JsonReader reader, Type objectType, IList<int>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return _converter.ReadJson(reader, objectType, ConvertIListToList(existingValue), hasExistingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, IList<int>? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, ConvertIListToList(value), serializer);
        }

        private List<int>? ConvertIListToList(IList<int>? src)
        {
            if (src == null) 
                return null;

            List<int>? dest = src as List<int>;
            if (dest != null)
                return dest;

            return new List<int>(src);
        }
    }
}
