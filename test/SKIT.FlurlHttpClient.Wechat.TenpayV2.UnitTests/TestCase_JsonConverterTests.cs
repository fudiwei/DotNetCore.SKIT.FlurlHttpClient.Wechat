using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class TestCase_JsonConverterTests
    {
        [Fact(DisplayName = "测试用例：自定义转换器之 `FlattenNArrayObjectConverterBase`")]
        public void TestFlattenNArrayObjectConverter()
        {
            var newtonsoftJsonSerializer = new FlurlNewtonsoftJsonSerializer();
            var systemTextJsonSerializer = new FlurlSystemTextJsonSerializer();

            string rawJson = "{\"return_code\":\"RETURN_CODE\",\"return_msg\":\"RETURN_MSG\",\"sign\":\"SIGN\",\"appid\":\"APPID\",\"mch_id\":\"MCH_ID\",\"result_code\":\"RESULT_CODE\",\"err_code\":\"ERR_CODE\",\"err_code_des\":\"ERR_CODE_DESC\",\"transaction_id\":\"TRANSACTION_ID\",\"count\":2,\"sub_order_no_0\":\"SUB_ORDER_NO_0\",\"sub_order_id_0\":\"SUB_ORDER_ID_0\",\"mch_customs_no_0\":\"MCH_CUSTOMS_NO_0\",\"customs_0\":\"CUSTOMS_0\",\"duty_0\":10,\"fee_type_0\":\"FEE_TYPE_0\",\"order_fee_0\":10,\"transport_fee_0\":10,\"product_fee_0\":10,\"state_0\":\"STATE_0\",\"explanation_0\":\"EXPLANATION_0\",\"modify_time_0\":\"20000101112233\",\"cert_check_result_0\":\"UNCHECKED\",\"sub_order_no_1\":\"SUB_ORDER_NO_1\",\"sub_order_id_1\":\"SUB_ORDER_ID_1\",\"mch_customs_no_1\":\"MCH_CUSTOMS_NO_1\",\"customs_1\":\"CUSTOMS_1\",\"duty_1\":11,\"fee_type_1\":\"FEE_TYPE_1\",\"order_fee_1\":11,\"transport_fee_1\":11,\"product_fee_1\":11,\"state_1\":\"STATE_1\",\"explanation_1\":\"EXPLANATION_1\",\"modify_time_1\":\"20010101112233\",\"cert_check_result_1\":\"UNCHECKED1\"}";
            var parsedObjByNewtonsoftJson = newtonsoftJsonSerializer.Deserialize<Models.QueryMerchantCustomsCustomDeclarationResponse>(rawJson);
            var parsedObjBySystemTextJson = systemTextJsonSerializer.Deserialize<Models.QueryMerchantCustomsCustomDeclarationResponse>(rawJson);

            Assert.Equal("RETURN_CODE", parsedObjByNewtonsoftJson.ReturnCode);
            Assert.Equal("RETURN_CODE", parsedObjBySystemTextJson.ReturnCode);
            Assert.Equal("RETURN_MSG", parsedObjByNewtonsoftJson.ReturnMessage);
            Assert.Equal("RETURN_MSG", parsedObjBySystemTextJson.ReturnMessage);
            Assert.Equal("SIGN", parsedObjByNewtonsoftJson.Signature);
            Assert.Equal("SIGN", parsedObjBySystemTextJson.Signature);
            Assert.Equal("APPID", parsedObjByNewtonsoftJson.AppId);
            Assert.Equal("APPID", parsedObjBySystemTextJson.AppId);
            Assert.Equal("MCH_ID", parsedObjByNewtonsoftJson.MerchantId);
            Assert.Equal("MCH_ID", parsedObjBySystemTextJson.MerchantId);
            Assert.Equal("RESULT_CODE", parsedObjByNewtonsoftJson.ResultCode);
            Assert.Equal("RESULT_CODE", parsedObjBySystemTextJson.ResultCode);
            Assert.Equal("ERR_CODE", parsedObjByNewtonsoftJson.ErrorCode);
            Assert.Equal("ERR_CODE", parsedObjBySystemTextJson.ErrorCode);
            Assert.Equal("ERR_CODE_DESC", parsedObjByNewtonsoftJson.ErrorCodeDescription);
            Assert.Equal("ERR_CODE_DESC", parsedObjBySystemTextJson.ErrorCodeDescription);
            Assert.Equal("TRANSACTION_ID", parsedObjByNewtonsoftJson.TransactionId);
            Assert.Equal("TRANSACTION_ID", parsedObjBySystemTextJson.TransactionId);
            Assert.Equal(2, parsedObjByNewtonsoftJson.RecordCount);
            Assert.Equal(2, parsedObjBySystemTextJson.RecordCount);
            Assert.Equal("SUB_ORDER_NO_0", parsedObjByNewtonsoftJson.RecordList[0].SubOrderNumber);
            Assert.Equal("SUB_ORDER_NO_0", parsedObjBySystemTextJson.RecordList[0].SubOrderNumber);
            Assert.Equal("SUB_ORDER_ID_0", parsedObjByNewtonsoftJson.RecordList[0].SubOrderId);
            Assert.Equal("SUB_ORDER_ID_0", parsedObjBySystemTextJson.RecordList[0].SubOrderId);
            Assert.Equal("MCH_CUSTOMS_NO_0", parsedObjByNewtonsoftJson.RecordList[0].MerchantCustomsNumber);
            Assert.Equal("MCH_CUSTOMS_NO_0", parsedObjBySystemTextJson.RecordList[0].MerchantCustomsNumber);
            Assert.Equal("CUSTOMS_0", parsedObjByNewtonsoftJson.RecordList[0].Customs);
            Assert.Equal("CUSTOMS_0", parsedObjBySystemTextJson.RecordList[0].Customs);
            Assert.Equal(10, parsedObjByNewtonsoftJson.RecordList[0].Duty);
            Assert.Equal(10, parsedObjBySystemTextJson.RecordList[0].Duty);
            Assert.Equal("FEE_TYPE_0", parsedObjByNewtonsoftJson.RecordList[0].FeeType);
            Assert.Equal("FEE_TYPE_0", parsedObjBySystemTextJson.RecordList[0].FeeType);
            Assert.Equal(DateTimeOffset.Parse("2000-01-01 11:22:33"), parsedObjByNewtonsoftJson.RecordList[0].ModifyTime);
            Assert.Equal(DateTimeOffset.Parse("2000-01-01 11:22:33"), parsedObjBySystemTextJson.RecordList[0].ModifyTime);
            Assert.Equal("SUB_ORDER_NO_1", parsedObjByNewtonsoftJson.RecordList[1].SubOrderNumber);
            Assert.Equal("SUB_ORDER_NO_1", parsedObjBySystemTextJson.RecordList[1].SubOrderNumber);
            Assert.Equal("SUB_ORDER_ID_1", parsedObjByNewtonsoftJson.RecordList[1].SubOrderId);
            Assert.Equal("SUB_ORDER_ID_1", parsedObjBySystemTextJson.RecordList[1].SubOrderId);
            Assert.Equal("MCH_CUSTOMS_NO_1", parsedObjByNewtonsoftJson.RecordList[1].MerchantCustomsNumber);
            Assert.Equal("MCH_CUSTOMS_NO_1", parsedObjBySystemTextJson.RecordList[1].MerchantCustomsNumber);
            Assert.Equal("CUSTOMS_1", parsedObjByNewtonsoftJson.RecordList[1].Customs);
            Assert.Equal("CUSTOMS_1", parsedObjBySystemTextJson.RecordList[1].Customs);
            Assert.Equal(11, parsedObjByNewtonsoftJson.RecordList[1].Duty);
            Assert.Equal(11, parsedObjBySystemTextJson.RecordList[1].Duty);
            Assert.Equal("FEE_TYPE_1", parsedObjByNewtonsoftJson.RecordList[1].FeeType);
            Assert.Equal("FEE_TYPE_1", parsedObjBySystemTextJson.RecordList[1].FeeType);
            Assert.Equal(DateTimeOffset.Parse("2001-01-01 11:22:33"), parsedObjByNewtonsoftJson.RecordList[1].ModifyTime);
            Assert.Equal(DateTimeOffset.Parse("2001-01-01 11:22:33"), parsedObjBySystemTextJson.RecordList[1].ModifyTime);

            string unparsedJsonByNewtonsoftJson = newtonsoftJsonSerializer.Serialize(parsedObjByNewtonsoftJson);
            string unparsedJsonBySystemTextJson = systemTextJsonSerializer.Serialize(parsedObjByNewtonsoftJson);

            Assert.Null(Record.Exception(() => Newtonsoft.Json.JsonConvert.DeserializeObject(unparsedJsonByNewtonsoftJson)));
            Assert.Null(Record.Exception(() => System.Text.Json.JsonDocument.Parse(unparsedJsonBySystemTextJson)));
            Assert.Contains("return_code", unparsedJsonByNewtonsoftJson);
            Assert.Contains("return_code", unparsedJsonBySystemTextJson);
            Assert.Contains("RETURN_CODE", unparsedJsonByNewtonsoftJson);
            Assert.Contains("RETURN_CODE", unparsedJsonBySystemTextJson);
            Assert.Contains("return_msg", unparsedJsonByNewtonsoftJson);
            Assert.Contains("return_msg", unparsedJsonBySystemTextJson);
            Assert.Contains("RETURN_MSG", unparsedJsonByNewtonsoftJson);
            Assert.Contains("RETURN_MSG", unparsedJsonBySystemTextJson);
            Assert.Contains("sub_order_no_0", unparsedJsonByNewtonsoftJson);
            Assert.Contains("sub_order_no_0", unparsedJsonBySystemTextJson);
            Assert.Contains("SUB_ORDER_NO_0", unparsedJsonByNewtonsoftJson);
            Assert.Contains("SUB_ORDER_NO_0", unparsedJsonBySystemTextJson);
            Assert.Contains("sub_order_id_0", unparsedJsonByNewtonsoftJson);
            Assert.Contains("sub_order_id_0", unparsedJsonBySystemTextJson);
            Assert.Contains("SUB_ORDER_ID_0", unparsedJsonByNewtonsoftJson);
            Assert.Contains("SUB_ORDER_ID_0", unparsedJsonBySystemTextJson);
            Assert.DoesNotContain("#n", unparsedJsonByNewtonsoftJson);
            Assert.DoesNotContain("#n", unparsedJsonBySystemTextJson);
            Assert.DoesNotContain("$n", unparsedJsonByNewtonsoftJson);
            Assert.DoesNotContain("$n", unparsedJsonBySystemTextJson);
        }
    }
}
