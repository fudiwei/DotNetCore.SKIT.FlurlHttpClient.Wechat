namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests.TestCases.APIs
{
    public class TestCase_ExecutePayTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /pay/unifiedorder）")]
        public async Task TestCase_ApiExecuteCreatePayUnifiedOrderTests()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            Assert.SkipWhen("" == ITConfigs.Fixtures_AppId, "【已跳过】未配置 \"Fixtures.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreatePayUnifiedOrderRequest()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                Body = "TEST_BODY",
                TotalFee = 1,
                ClientIp = "127.0.0.7",
                AppId = ITConfigs.Fixtures_AppId,
                OpenId = ITConfigs.Fixtures_OpenId,
                TradeType = "JSAPI",
                NotifyUrl = "https://example.com"
            };
            var response = await client.ExecuteCreatePayUnifiedOrderAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /pay/micropay）")]
        public async Task TestCase_ApiExecuteCreatePayMicroPayTests()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreatePayMicroPayRequest()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                Body = "TEST_BODY",
                TotalFee = 1,
                ClientIp = "127.0.0.7",
                AuthCode = "TEST_AUTH_CODE"
            };
            var response = await client.ExecuteCreatePayMicroPayAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.TransactionId);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /secapi/pay/refund）")]
        public async Task TestCase_ApiExecuteCreatePayRefundTests()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            Assert.SkipWhen(0 == ITConfigs.Credentials_MerchantCertificateBytes.Length, "【已跳过】未配置 \"Credentials.MerchantCertificateBase64String\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreatePayRefundRequest()
            {
                OutTradeNumber = "TSET_OTN_FAKE",
                OutRefundNumber = "TEST_ORN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                TotalFee = 1,
                RefundFee = 1,
                Description = "TEST_DESC"
            };
            var response = await client.ExecuteCreatePayRefundAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
