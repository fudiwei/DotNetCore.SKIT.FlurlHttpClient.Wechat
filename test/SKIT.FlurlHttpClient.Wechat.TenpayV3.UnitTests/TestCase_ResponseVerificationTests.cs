using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ResponseVerificationTests
    {
        [Fact(DisplayName = "测试用例：验证响应签名")]
        public async Task TestVerifyResponseSignature()
        {
            await TestClients.InitializeCertificateManagerAsync();

            var request = new Models.QueryCertificatesRequest();
            var response = await TestClients.Instance.ExecuteQueryCertificatesAsync(request);

            Assert.True(response.RawStatus == 200);
            Assert.True(response.RawHeaders.Count > 0);
            Assert.True(response.RawBytes.Length > 0);
            Assert.True(TestClients.Instance.VerifyResponseSignature(response));
            Assert.NotNull(response.WechatpayRequestId);
            Assert.NotNull(response.WechatpayNonce);
            Assert.NotNull(response.WechatpayTimestamp);
            Assert.NotNull(response.WechatpaySignature);
            Assert.NotNull(response.WechatpaySignatureType);
            Assert.NotNull(response.WechatpayCertificateSerialNumber);
        }
    }
}
