namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases.APIs
{
    public class TestCase_ExecutePayTransactionsTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /pay/transactions/app）")]
        public async Task TestExecuteCreatePayTransactionApp()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_AppId, "【已跳过】未配置 \"Fixtures.AppId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreatePayTransactionAppRequest()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = ITConfigs.Fixtures_AppId,
                Description = "FAKE_DESC",
                NotifyUrl = "http://127.0.0.1",
                Amount = new Models.CreatePayTransactionAppRequest.Types.Amount()
                {
                    Total = 1
                }
            };
            var response = await client.ExecuteCreatePayTransactionAppAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /pay/transactions/jsapi）")]
        public async Task TestExecuteCreatePayTransactionJsapi()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_AppId, "【已跳过】未配置 \"Fixtures.AppId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreatePayTransactionJsapiRequest()
            {
                OutTradeNumber = "TEST" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = ITConfigs.Fixtures_AppId,
                Description = "FAKE_DESC",
                ExpireTime = DateTimeOffset.Now.AddMinutes(30),
                NotifyUrl = "http://127.0.0.1",
                Amount = new Models.CreatePayTransactionJsapiRequest.Types.Amount()
                {
                    Total = 1
                },
                Payer = new Models.CreatePayTransactionJsapiRequest.Types.Payer()
                {
                    OpenId = ITConfigs.Fixtures_OpenId
                }
            };
            var response = await client.ExecuteCreatePayTransactionJsapiAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /pay/transactions/id/{transaction_id}）")]
        public async Task TestExecuteGetPayTransactionById()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_TransactionId, "【已跳过】未配置 \"Fixtures.TransactionId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.GetPayTransactionByIdRequest()
            {
                TransactionId = ITConfigs.Fixtures_TransactionId
            };
            var response = await client.ExecuteGetPayTransactionByIdAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.NotNull(response.AppId);
            Assert.NotNull(response.MerchantId);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.TransactionId);
            Assert.NotNull(response.TradeState);
            Assert.NotNull(response.TradeStateDescription);
            Assert.NotNull(response.Amount);
            Assert.True(response.Amount.Total > 0);
        }
    }
}
