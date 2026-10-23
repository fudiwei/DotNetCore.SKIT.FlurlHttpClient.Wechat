namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases
{
    public class TestCase_ResponseVerificationTests
    {
        [Fact(DisplayName = "测试用例：验证响应签名（基于 RSA）")]
        public async Task TestVerifyResponseSignatureUseRSA()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantRSACertificateSerialNumber\" 或 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantRSACertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantRSACertificatePrivateKey\"。");

            using var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = ITConfigs.Credentials_MerchantId,
                MerchantV3Secret = ITConfigs.Credentials_MerchantSecret,
                MerchantCertificateSerialNumber = ITConfigs.Credentials_MerchantRSACertificateSerialNumber,
                MerchantCertificatePrivateKey = ITConfigs.Credentials_MerchantRSACertificatePrivateKey,
                PlatformCertificateManager = new Settings.InMemoryCertificateManager(),
                AutoDecryptResponseSensitiveProperty = true
            });

            var request = new Models.QueryCertificatesRequest() { AlgorithmType = "RSA" };
            var response = await client.ExecuteQueryCertificatesAsync(request, TestContext.Current.CancellationToken);
            foreach (var certificate in response.CertificateList)
            {
                client.PlatformCertificateManager.AddEntry(Settings.CertificateEntry.Parse(certificate));
            }

            Assert.NotNull(response.WechatpayRequestId);
            Assert.NotNull(response.WechatpayNonce);
            Assert.NotNull(response.WechatpayTimestamp);
            Assert.NotNull(response.WechatpaySignature);
            Assert.NotNull(response.WechatpaySignatureType);
            Assert.NotNull(response.WechatpaySerialNumber);
            Assert.True(client.VerifyResponseSignature(response));
        }

        [Fact(DisplayName = "测试用例：验证响应签名（基于 SM2）")]
        public async Task TestVerifyResponseSignatureUseSM2()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantId, "【已跳过】未配置 \"Credentials.MerchantId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSecret, "【已跳过】未配置 \"Credentials.MerchantSecret\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSM2CertificateSerialNumber, "【已跳过】未配置 \"Credentials.MerchantSM2CertificateSerialNumber\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_MerchantSM2CertificatePrivateKey, "【已跳过】未配置 \"Credentials.MerchantSM2CertificatePrivateKey\"。");

            using var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = ITConfigs.Credentials_MerchantId,
                MerchantV3Secret = ITConfigs.Credentials_MerchantSecret,
                MerchantCertificateSerialNumber = ITConfigs.Credentials_MerchantSM2CertificateSerialNumber,
                MerchantCertificatePrivateKey = ITConfigs.Credentials_MerchantSM2CertificatePrivateKey,
                SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3,
                PlatformCertificateManager = new Settings.InMemoryCertificateManager(),
                AutoDecryptResponseSensitiveProperty = true
            });

            var request = new Models.QueryCertificatesRequest() { AlgorithmType = "SM2" };
            var response = await client.ExecuteQueryCertificatesAsync(request, TestContext.Current.CancellationToken);
            foreach (var certificate in response.CertificateList)
            {
                client.PlatformCertificateManager.AddEntry(Settings.CertificateEntry.Parse(certificate));
            }

            Assert.NotNull(response.WechatpayRequestId);
            Assert.NotNull(response.WechatpayNonce);
            Assert.NotNull(response.WechatpayTimestamp);
            Assert.NotNull(response.WechatpaySignature);
            Assert.NotNull(response.WechatpaySignatureType);
            Assert.NotNull(response.WechatpaySerialNumber);
            Assert.True(client.VerifyResponseSignature(response));
        }
    }
}
