using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualIntegerListWithPipeSplitConverter : JsonConverter
    {
        private readonly JsonConverter<int[]?> _converter = new TextualIntegerArrayWithPipeSplitConverter();

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(objectType.GetGenericTypeDefinition()) &&
                   typeof(int) == objectType.GetGenericArguments()[0];
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
            int[]? array = _converter.ReadJson(reader, objectType, null, false, serializer);
            return array?.ToList();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, ((IList<int>?)value)?.ToArray(), serializer);
        }
    }
}
