namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteRefundTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /refund/domestic/refunds）")]
        public async Task TestExecuteCreateRefundDomesticRefund()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreateRefundDomesticRefundRequest()
            {
                OutTradeNumber = "TEST_OTN_FAKE",
                OutRefundNumber = "TEST_ORN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                Amount = new Models.CreateRefundDomesticRefundRequest.Types.Amount()
                {
                    Total = 1,
                    Refund = 1
                },
                Reason = "FAKE_REASON"
            };
            var response = await client.ExecuteCreateRefundDomesticRefundAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.OutRefundNumber);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.Channel);
            Assert.NotNull(response.Status);
            Assert.NotNull(response.Amount);
            Assert.True(response.Amount.Total > 0);
            Assert.True(response.Amount.Refund > 0);
            Assert.True(response.Amount.PayerTotal > 0);
            Assert.True(response.Amount.PayerRefund > 0);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /refund/domestic/refunds/{out_refund_no}）")]
        public async Task TestExecuteGetRefundDomesticRefundByOutRefundNumber()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.GetRefundDomesticRefundByOutRefundNumberRequest()
            {
                OutRefundNumber = "TEST_ORN_FAKE"
            };
            var response = await client.ExecuteGetRefundDomesticRefundByOutRefundNumberAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.RefundId);
            Assert.NotNull(response.OutRefundNumber);
            Assert.NotNull(response.TransactionId);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.Channel);
            Assert.NotNull(response.Status);
            Assert.NotNull(response.UserReceivedAccount);
            Assert.NotNull(response.FundsAccount);
            Assert.NotNull(response.Amount);
            Assert.True(response.Amount.Total > 0);
            Assert.True(response.Amount.Refund > 0);
            Assert.True(response.Amount.PayerTotal > 0);
            Assert.True(response.Amount.PayerRefund > 0);
        }
    }
}
