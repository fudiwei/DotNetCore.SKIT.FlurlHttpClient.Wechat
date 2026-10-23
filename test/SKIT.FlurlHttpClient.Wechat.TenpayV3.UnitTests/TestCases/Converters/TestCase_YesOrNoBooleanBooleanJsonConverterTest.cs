namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases.Converters
{
    public class TestCase_YesOrNoBooleanBooleanJsonConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 1)]
            [Newtonsoft.Json.JsonConverter(typeof(TenpayV3.Converters.NewtonsoftJson.YesOrNoBooleanConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(1)]
            [System.Text.Json.Serialization.JsonConverter(typeof(TenpayV3.Converters.SystemTextJson.YesOrNoBooleanConverter))]
            public bool Property { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 2)]
            [Newtonsoft.Json.JsonConverter(typeof(TenpayV3.Converters.NewtonsoftJson.YesOrNoBooleanConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(2)]
            [System.Text.Json.Serialization.JsonConverter(typeof(TenpayV3.Converters.SystemTextJson.YesOrNoBooleanConverter))]
            public bool? NullableProperty { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { NullableProperty = null };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":\"N\"}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"N\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":null}").NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{}").NullableProperty);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = false, NullableProperty = false };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":\"N\",\"NullableProperty\":\"N\"}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":false}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":false}").NullableProperty);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = true, NullableProperty = true };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":\"Y\",\"NullableProperty\":\"Y\"}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":true}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":true}").NullableProperty);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 JSON 转换器 `YesOrNoBooleanConverter`")]
        public void TestYesOrNoBooleanJsonConverter()
        {
            Assert.Multiple(() =>
            {
                var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
                jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
                jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

                TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
            });

            Assert.Multiple(() =>
            {
                var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
                jsonOptions.WriteIndented = false;
                jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

                TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
            });
        }
    }
}
