using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualLongListWithPipeSplitConverter : JsonConverter
    {
        private readonly JsonConverter<long[]?> _converter = new TextualLongArrayWithPipeSplitConverter();

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(objectType.GetGenericTypeDefinition()) &&
                   typeof(long) == objectType.GetGenericArguments()[0];
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            long[]? array = _converter.ReadJson(reader, objectType, null, false, serializer);
            return array?.ToList();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, ((IList<long>?)value)?.ToArray(), serializer);
        }
    }
}
