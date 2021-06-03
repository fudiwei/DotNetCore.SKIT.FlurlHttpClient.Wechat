using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayConverterTests
    {
        class JsonDateTimeOffsetTestEntity
        {
            [Newtonsoft.Json.JsonProperty("datetime_rfc3339")]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
            [System.Text.Json.Serialization.JsonPropertyName("datetime_rfc3339")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
            public DateTimeOffset DateTimeWithRFC3339 { get; set; }

            [Newtonsoft.Json.JsonProperty("nullable_datetime_rfc3339")]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
            [System.Text.Json.Serialization.JsonPropertyName("nullable_datetime_rfc3339")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
            public DateTimeOffset? NullableDateTimeWithRFC3339 { get; set; }
        }
        
        class JsonStringTypedStringListOrArrayTestEntity
        {
            [Newtonsoft.Json.JsonProperty("string_ilist")]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.JsonTypedStringIListConverter))]
            [System.Text.Json.Serialization.JsonPropertyName("string_ilist")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.JsonTypedStringIListConverter))]
            public IList<string> StringTypedIList { get; set; }

            [Newtonsoft.Json.JsonProperty("string_list")]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.JsonTypedStringListConverter))]
            [System.Text.Json.Serialization.JsonPropertyName("string_list")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.JsonTypedStringListConverter))]
            public List<string> StringTypedList { get; set; }

            [Newtonsoft.Json.JsonProperty("string_array")]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.JsonTypedStringArrayConverter))]
            [System.Text.Json.Serialization.JsonPropertyName("string_array")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.JsonTypedStringArrayConverter))]
            public string[] StringTypedArray { get; set; }
        }

        [Fact(DisplayName = "日期时间 JSON 序列化 / 反序列化")]
        public void JsonDateTimeOffsetTest()
        {
            const string FORMAT_RFC3339 = "yyyy-MM-dd'T'HH:mm:sszzz";

            string datestr = "2018-06-08T10:34:56+08:00";
            var date = DateTimeOffset.Parse(datestr);
            var raw = new JsonDateTimeOffsetTestEntity();

            Assert.Equal(datestr, date.ToString(FORMAT_RFC3339));

            raw.DateTimeWithRFC3339 = date;
            raw.NullableDateTimeWithRFC3339 = date;
            var json = new FlurlNewtonsoftJsonSerializer().Serialize(raw);
            var entity = new FlurlNewtonsoftJsonSerializer().Deserialize<JsonDateTimeOffsetTestEntity>(json);

            Assert.Contains($"\"datetime_rfc3339\":\"{datestr}\"", json);
            Assert.Contains($"\"nullable_datetime_rfc3339\":\"{datestr}\"", json);
            Assert.Equal(raw.DateTimeWithRFC3339, entity.DateTimeWithRFC3339);
            Assert.Equal(raw.NullableDateTimeWithRFC3339, entity.NullableDateTimeWithRFC3339);

            raw.NullableDateTimeWithRFC3339 = null;
            json = new FlurlNewtonsoftJsonSerializer().Serialize(raw);
            entity = new FlurlNewtonsoftJsonSerializer().Deserialize<JsonDateTimeOffsetTestEntity>(json);

            Assert.Equal(datestr, date.ToString(FORMAT_RFC3339));
            Assert.DoesNotContain($"\"nullable_datetime_rfc3339\"", json);
            Assert.Null(entity.NullableDateTimeWithRFC3339);

            json = new FlurlSystemTextJsonSerializer().Serialize(raw);
            entity = new FlurlSystemTextJsonSerializer().Deserialize<JsonDateTimeOffsetTestEntity>(json);

            Assert.Equal(datestr, date.ToString(FORMAT_RFC3339));
            Assert.DoesNotContain($"\"nullable_datetime_rfc3339\"", json);
            Assert.Null(entity.NullableDateTimeWithRFC3339);
        }

        [Fact(DisplayName = "字符串类型的字符串列表、数组 JSON 序列化 / 反序列化")]
        public void JsonStringTypedStringListOrArrayTest()
        {
            const string STR = "test";

            var raw = new JsonStringTypedStringListOrArrayTestEntity();
            raw.StringTypedIList = new List<string>() { STR };
            raw.StringTypedList = new List<string>() { STR };
            raw.StringTypedArray = new string[] { STR };

            var json = new FlurlNewtonsoftJsonSerializer().Serialize(raw);
            var entity = new FlurlNewtonsoftJsonSerializer().Deserialize<JsonDateTimeOffsetTestEntity>(json);

            Assert.Contains($"\"string_ilist\":\"[\\\"{STR}\\\"]\"", json);
            Assert.Contains($"\"string_list\":\"[\\\"{STR}\\\"]\"", json);
            Assert.Contains($"\"string_array\":\"[\\\"{STR}\\\"]\"", json);
            Assert.Contains(raw.StringTypedIList, e => STR.Equals(e));
            Assert.Contains(raw.StringTypedList, e => STR.Equals(e));
            Assert.Contains(raw.StringTypedArray, e => STR.Equals(e));

            json = new FlurlSystemTextJsonSerializer().Serialize(raw);
            entity = new FlurlSystemTextJsonSerializer().Deserialize<JsonDateTimeOffsetTestEntity>(json);

            Assert.Contains($"\"string_ilist\":\"[\\\"{STR}\\\"]\"", json);
            Assert.Contains($"\"string_list\":\"[\\\"{STR}\\\"]\"", json);
            Assert.Contains($"\"string_array\":\"[\\\"{STR}\\\"]\"", json);
            Assert.Contains(raw.StringTypedIList, e => STR.Equals(e));
            Assert.Contains(raw.StringTypedList, e => STR.Equals(e));
            Assert.Contains(raw.StringTypedArray, e => STR.Equals(e));
        }
    }
}
