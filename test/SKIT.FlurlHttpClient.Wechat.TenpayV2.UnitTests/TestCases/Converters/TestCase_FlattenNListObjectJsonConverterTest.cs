namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests.TestCases.Converters
{
    public class TestCase_FlattenNListObjectJsonConverterTest
    {
        [Newtonsoft.Json.JsonConverter(typeof(MockObject.Converters.MockObjectNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(MockObject.Converters.MockObjectSystemTextJsonConverter))]
        private sealed class MockObject
        {
            public static class Types
            {
                public class Element
                {
                    [Newtonsoft.Json.JsonProperty("element_id_$n")]
                    [System.Text.Json.Serialization.JsonPropertyName("element_id_$n")]
                    public string? Id { get; set; }

                    [Newtonsoft.Json.JsonProperty("element_name_$n")]
                    [System.Text.Json.Serialization.JsonPropertyName("element_name_$n")]
                    public string? Name { get; set; }

                    [Newtonsoft.Json.JsonProperty("element_amount_$n")]
                    [System.Text.Json.Serialization.JsonPropertyName("element_amount_$n")]
                    [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                    public int Amount { get; set; }
                }
            }

            public static class Converters
            {
                internal sealed class MockObjectNewtonsoftJsonConverter : TenpayV2.Converters.NewtonsoftJson.FlattenNListObjectConverterBase<MockObject, Types.Element>
                {
                    protected override System.Reflection.PropertyInfo FlattenProperty => MockObject._flattenProperty;
                }

                internal sealed class MockObjectSystemTextJsonConverter : TenpayV2.Converters.SystemTextJson.FlattenNListObjectConverterBase<MockObject, Types.Element>
                {
                    protected override System.Reflection.PropertyInfo FlattenProperty => MockObject._flattenProperty;
                }
            }

            private static readonly System.Reflection.PropertyInfo _flattenProperty = typeof(MockObject).GetProperty(nameof(Elements), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public)!;

            [Newtonsoft.Json.JsonProperty("id")]
            [System.Text.Json.Serialization.JsonPropertyName("id")]
            public string? Id { get; set; }

            [Newtonsoft.Json.JsonProperty("count")]
            [System.Text.Json.Serialization.JsonPropertyName("count")]
            public int? Count { get; set; }

            [Newtonsoft.Json.JsonProperty("#n")]
            [System.Text.Json.Serialization.JsonPropertyName("#n")]
            public List<Types.Element>? Elements { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                string json = "{\"id\":\"ID\",\"count\":2,\"element_id_0\":\"ID_0\",\"element_name_0\":\"NAME_0\",\"element_amount_0\":10,\"element_id_1\":\"ID_1\",\"element_name_1\":\"NAME_1\",\"element_amount_1\":\"11\"}";
                var actualObj = jsonSerializer.Deserialize<MockObject>(json);

                Assert.Equal("ID", actualObj.Id);
                Assert.Equal(2, actualObj.Count);
                Assert.Equal(2, actualObj.Elements!.Count);
                Assert.Equal("ID_0", actualObj.Elements![0].Id);
                Assert.Equal("NAME_0", actualObj.Elements![0].Name);
                Assert.Equal(10, actualObj.Elements![0].Amount);
                Assert.Equal("ID_1", actualObj.Elements![1].Id);
                Assert.Equal("NAME_1", actualObj.Elements![1].Name);
                Assert.Equal(11, actualObj.Elements![1].Amount);
            });

            Assert.Multiple(() =>
            {
                var actualObj = jsonSerializer.Deserialize<MockObject>("{}");

                Assert.Null(actualObj.Id);
                Assert.Null(actualObj.Count);
                Assert.Null(actualObj.Elements);
            });

            Assert.Multiple(() =>
            {
                var actualObj = jsonSerializer.Deserialize<MockObject>("{\"id\":\"ID\",\"element_id_1\":\"ID_1\"}");

                Assert.Equal("ID", actualObj.Id);
                Assert.Equal(2, actualObj.Elements!.Count);
                Assert.Null(actualObj.Elements![0]);
                Assert.Equal("ID_1", actualObj.Elements![1].Id);
            });

            Assert.Multiple(() =>
            {
                var expectedObj = new MockObject()
                {
                    Id = "ID",
                    Count = 2,
                    Elements = new List<MockObject.Types.Element>()
                    {
                        new MockObject.Types.Element() { Id = "ID_0", Name = "NAME_0", Amount = 10 },
                        new MockObject.Types.Element() { Id = "ID_1", Name = "NAME_1", Amount = 11 },
                    }
                };
                string actualJson = jsonSerializer.Serialize(expectedObj);

                Assert.Null(Record.Exception(() => jsonSerializer.Deserialize<dynamic>(actualJson)));

                Assert.DoesNotContain("#n", actualJson);
                Assert.DoesNotContain("$n", actualJson);
                Assert.DoesNotContain("_flattenProperty", actualJson);
                Assert.DoesNotContain(nameof(MockObject.Elements), actualJson);

                Assert.Contains("\"id\":\"ID\"", actualJson);
                Assert.Contains("\"count\":2", actualJson);
                Assert.Contains("\"element_id_0\":\"ID_0\"", actualJson);
                Assert.Contains("\"element_name_0\":\"NAME_0\"", actualJson);
                Assert.Contains("\"element_amount_0\":10", actualJson);
                Assert.Contains("\"element_id_1\":\"ID_1\"", actualJson);
                Assert.Contains("\"element_name_1\":\"NAME_1\"", actualJson);
                Assert.Contains("\"element_amount_1\":11", actualJson);

                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);
                Assert.Equal(expectedObj.Id, actualObj.Id);
                Assert.Equal(expectedObj.Count, actualObj.Count);
                Assert.Equal(2, actualObj.Elements!.Count);
                Assert.Equal("NAME_1", actualObj.Elements![1].Name);
            });

            Assert.Multiple(() =>
            {
                string actualJson = jsonSerializer.Serialize(new MockObject() { Id = "ID", Elements = null });

                Assert.Contains("\"id\":\"ID\"", actualJson);
                Assert.DoesNotContain("element_", actualJson);
            });

            Assert.Multiple(() =>
            {
                string actualJson = jsonSerializer.Serialize(new MockObject()
                {
                    Elements = new List<MockObject.Types.Element>()
                    {
                        null!,
                        new MockObject.Types.Element() { Id = "ID_1" },
                    }
                });

                Assert.DoesNotContain("element_id_0", actualJson);
                Assert.Contains("\"element_id_1\":\"ID_1\"", actualJson);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 JSON 转换器 `FlattenNListObjectConverter`")]
        public void TestFlattenNListObjectConverterJsonConverter()
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
