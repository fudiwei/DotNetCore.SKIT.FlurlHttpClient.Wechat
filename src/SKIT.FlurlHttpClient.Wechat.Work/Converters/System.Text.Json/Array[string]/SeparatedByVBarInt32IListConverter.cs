using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class SeparatedByVBarInt32IListConverter : JsonConverter<IList<int>?>
    {
        private readonly JsonConverter<List<int>?> _converter = new SeparatedByVBarInt32ListConverter();

        public override IList<int>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, IList<int>? value, JsonSerializerOptions options)
        {
            _converter.Write(writer, ConvertIListToList(value), options);
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
