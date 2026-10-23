namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests.TestCases
{
    public class TestCase_WebhookEventTests
    {
        [Fact(DisplayName = "测试用例：验证回调通知签名")]
        public void TestVerifyEventSignature()
        {
            const string merchantId = "10000100";
            const string merchantSecret = "192006250b4c09247ec02edce69f6a2d";

            using var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = merchantId,
                MerchantSecret = merchantSecret
            });

            const string xml = "<xml><appid>wxd930ea5d5a258f4f</appid><mch_id>10000100</mch_id><device_info>1000</device_info><body>test</body><nonce_str>ibuaiVcKdpRxkhJA</nonce_str><sign>9A0A8659F005D6984697E2CA0A9CF3B7</sign></xml>";
            Assert.True(client.VerifyEventSignature(xml));
        }
    }
}
