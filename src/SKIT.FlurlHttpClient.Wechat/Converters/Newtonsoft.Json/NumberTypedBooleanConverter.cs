using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class NumberTypedBooleanConverter : JsonConverter<bool>
    {
        private readonly JsonConverter<bool?> _converter = new NumberTypedNullableBooleanConverter();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return _converter.ReadJson(reader, objectType, existingValue, hasExistingValue, serializer) ?? default;
        }

        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, value, serializer);
        }
    }
}
