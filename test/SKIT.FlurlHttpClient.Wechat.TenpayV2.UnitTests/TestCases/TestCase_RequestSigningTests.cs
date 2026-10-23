using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests.TestCases
{
    public class TestCase_RequestSigningTests
    {
        internal sealed class MockRequest : WechatTenpaySignableRequest
        {
            [Newtonsoft.Json.JsonProperty("appid")]
            [System.Text.Json.Serialization.JsonPropertyName("appid")]
            public override string? AppId { get; set; }

            [Newtonsoft.Json.JsonProperty("mch_id")]
            [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
            public override string? MerchantId { get; set; }

            [Newtonsoft.Json.JsonProperty("device_info")]
            [System.Text.Json.Serialization.JsonPropertyName("device_info")]
            public string? DeviceInfo { get; set; }

            [Newtonsoft.Json.JsonProperty("body")]
            [System.Text.Json.Serialization.JsonPropertyName("body")]
            public string? Body { get; set; }
        }

        [Fact(DisplayName = "测试用例：生成请求签名")]
        public void TestRequestSigning()
        {
            const string merchantId = "10000100";
            const string merchantSecret = "192006250b4c09247ec02edce69f6a2d";

            using var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = merchantId,
                MerchantSecret = merchantSecret
            });

            var request = new MockRequest()
            {
                AppId = "wxd930ea5d5a258f4f",
                MerchantId = merchantId,
                DeviceInfo = "1000",
                Body = "test",
                NonceString = "ibuaiVcKdpRxkhJA"
            };
            client.CreateFlurlRequest(request, HttpMethod.Post);

            string actualSign = "9A0A8659F005D6984697E2CA0A9CF3B7";
            string expectedSign = request.Signature!;
            Assert.Equal(actualSign, expectedSign, ignoreCase: true);
        }
    }
}
