using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class TestCase_JsonConverterOfFlattenNArrayObjectTest
    {
        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                string expectedJson = "{\"return_code\":\"RETURN_CODE\",\"return_msg\":\"RETURN_MSG\",\"sign\":\"SIGN\",\"appid\":\"APPID\",\"mch_id\":\"MCH_ID\",\"result_code\":\"RESULT_CODE\",\"err_code\":\"ERR_CODE\",\"err_code_des\":\"ERR_CODE_DESC\",\"transaction_id\":\"TRANSACTION_ID\",\"count\":2,\"sub_order_no_0\":\"SUB_ORDER_NO_0\",\"sub_order_id_0\":\"SUB_ORDER_ID_0\",\"mch_customs_no_0\":\"MCH_CUSTOMS_NO_0\",\"customs_0\":\"CUSTOMS_0\",\"duty_0\":10,\"fee_type_0\":\"FEE_TYPE_0\",\"order_fee_0\":10,\"transport_fee_0\":10,\"product_fee_0\":10,\"state_0\":\"STATE_0\",\"explanation_0\":\"EXPLANATION_0\",\"modify_time_0\":\"20000101112233\",\"cert_check_result_0\":\"UNCHECKED\",\"sub_order_no_1\":\"SUB_ORDER_NO_1\",\"sub_order_id_1\":\"SUB_ORDER_ID_1\",\"mch_customs_no_1\":\"MCH_CUSTOMS_NO_1\",\"customs_1\":\"CUSTOMS_1\",\"duty_1\":11,\"fee_type_1\":\"FEE_TYPE_1\",\"order_fee_1\":11,\"transport_fee_1\":11,\"product_fee_1\":11,\"state_1\":\"STATE_1\",\"explanation_1\":\"EXPLANATION_1\",\"modify_time_1\":\"20010101112233\",\"cert_check_result_1\":\"UNCHECKED1\"}";
                var actualObj = jsonSerializer.Deserialize<Models.QueryMerchantCustomsCustomDeclarationResponse>(expectedJson);

                Assert.Equal("RETURN_CODE", actualObj.ReturnCode);
                Assert.Equal("RETURN_MSG", actualObj.ReturnMessage);
                Assert.Equal("SIGN", actualObj.Signature);
                Assert.Equal("APPID", actualObj.AppId);
                Assert.Equal("MCH_ID", actualObj.MerchantId);
                Assert.Equal("RESULT_CODE", actualObj.ResultCode);
                Assert.Equal("ERR_CODE", actualObj.ErrorCode);
                Assert.Equal("ERR_CODE_DESC", actualObj.ErrorCodeDescription);
                Assert.Equal("TRANSACTION_ID", actualObj.TransactionId);
                Assert.Equal(2, actualObj.RecordCount);
                Assert.Equal("SUB_ORDER_NO_0", actualObj.RecordList[0].SubOrderNumber);
                Assert.Equal("SUB_ORDER_ID_0", actualObj.RecordList[0].SubOrderId);
                Assert.Equal("MCH_CUSTOMS_NO_0", actualObj.RecordList[0].MerchantCustomsNumber);
                Assert.Equal("CUSTOMS_0", actualObj.RecordList[0].Customs);
                Assert.Equal(10, actualObj.RecordList[0].Duty);
                Assert.Equal("FEE_TYPE_0", actualObj.RecordList[0].FeeType);
                Assert.Equal(DateTimeOffset.Parse("2000-01-01 11:22:33"), actualObj.RecordList[0].ModifyTime);
                Assert.Equal("SUB_ORDER_NO_1", actualObj.RecordList[1].SubOrderNumber);
                Assert.Equal("SUB_ORDER_ID_1", actualObj.RecordList[1].SubOrderId);
                Assert.Equal("MCH_CUSTOMS_NO_1", actualObj.RecordList[1].MerchantCustomsNumber);
                Assert.Equal("CUSTOMS_1", actualObj.RecordList[1].Customs);
                Assert.Equal(11, actualObj.RecordList[1].Duty);
                Assert.Equal("FEE_TYPE_1", actualObj.RecordList[1].FeeType);
                Assert.Equal(DateTimeOffset.Parse("2001-01-01 11:22:33"), actualObj.RecordList[1].ModifyTime);
            });

            Assert.Multiple(() =>
            {
                var expectedObj = new Models.QueryMerchantCustomsCustomDeclarationResponse()
                {
                    ReturnCode = "RETURN_CODE",
                    ReturnMessage = "RETURN_MSG",
                    AppId = "APPID",
                    MerchantId = "MCH_ID",
                    ResultCode = "RESULT_CODE",
                    ErrorCode = "ERR_CODE",
                    ErrorCodeDescription = "ERR_CODE_DESC",
                    TransactionId = "TRANSACTION_ID",
                    RecordCount = 2,
                    RecordList = new Models.QueryMerchantCustomsCustomDeclarationResponse.Types.Record[]
                    {
                        new Models.QueryMerchantCustomsCustomDeclarationResponse.Types.Record()
                        {
                            SubOrderNumber = "SUB_ORDER_NO_0",
                            SubOrderId = "SUB_ORDER_ID_0",
                            MerchantCustomsNumber = "MCH_CUSTOMS_NO_0",
                            Customs = "CUSTOMS_0",
                            Duty = 10,
                            FeeType = "FEE_TYPE_0",
                            ModifyTime = DateTimeOffset.Parse("2000-01-01 11:22:33"),
                        },
                        new Models.QueryMerchantCustomsCustomDeclarationResponse.Types.Record()
                        {
                            SubOrderNumber = "SUB_ORDER_NO_1",
                            SubOrderId = "SUB_ORDER_ID_1",
                            MerchantCustomsNumber = "MCH_CUSTOMS_NO_1",
                            Customs = "CUSTOMS_1",
                            Duty = 11,
                            FeeType = "FEE_TYPE_1",
                            ModifyTime = DateTimeOffset.Parse("2001-01-01 11:22:33"),
                        }
                    }
                };
                string actualJson = jsonSerializer.Serialize(expectedObj);

                Assert.Null(Record.Exception(() => jsonSerializer.Deserialize<dynamic>(actualJson)));

                Assert.DoesNotContain("#n", actualJson);
                Assert.DoesNotContain("$n", actualJson);

                Assert.Contains("\"return_code\"", actualJson);
                Assert.Contains("\"RETURN_CODE\"", actualJson);
                Assert.Contains("\"return_msg\"", actualJson);
                Assert.Contains("\"RETURN_MSG\"", actualJson);
                Assert.Contains("\"sub_order_no_0\"", actualJson);
                Assert.Contains("\"SUB_ORDER_NO_0\"", actualJson);
                Assert.Contains("\"sub_order_id_0\"", actualJson);
                Assert.Contains("\"SUB_ORDER_ID_0\"", actualJson);
                Assert.Contains("\"sub_order_no_1\"", actualJson);
                Assert.Contains("\"SUB_ORDER_NO_1\"", actualJson);
                Assert.Contains("\"sub_order_id_1\"", actualJson);
                Assert.Contains("\"SUB_ORDER_ID_1\"", actualJson);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 FlattenNArrayObjectConverterBase")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 FlattenNArrayObjectConverterBase")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;
            jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
