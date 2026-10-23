namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteBillTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /bill/tradebill）")]
        public async Task TestExecuteGetBillTradeBill()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.GetBillTradeBillRequest()
            {
                BillDateString = DateTimeOffset.Now.AddDays(-7).ToString("yyyy-MM-dd")
            };
            var response = await client.ExecuteGetBillTradeBillAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.HashType);
            Assert.NotNull(response.HashValue);
            Assert.NotNull(response.DownloadUrl);

            var download = await client.ExecuteDownloadBillFileAsync(new Models.DownloadBillFileRequest() { DownloadUrl = response.DownloadUrl }, TestContext.Current.CancellationToken);
            Assert.True(download.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /bill/fundflowbill）")]
        public async Task TestExecuteGetBillFundflowBill()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber && "" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey && "" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\" 或 \"Credentials.MerchantSM2CertificatePrivateKey\"。");
            
            using var client = ITClients.CreateInstance();
            var request = new Models.GetBillFundflowBillRequest()
            {
                BillDateString = DateTimeOffset.Now.AddDays(-7).ToString("yyyy-MM-dd")
            };
            var response = await client.ExecuteGetBillFundflowBillAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.HashType);
            Assert.NotNull(response.HashValue);
            Assert.NotNull(response.DownloadUrl);

            var download = await client.ExecuteDownloadBillFileAsync(new Models.DownloadBillFileRequest() { DownloadUrl = response.DownloadUrl }, TestContext.Current.CancellationToken);
            Assert.True(download.IsSuccessful());
        }
    }
}
