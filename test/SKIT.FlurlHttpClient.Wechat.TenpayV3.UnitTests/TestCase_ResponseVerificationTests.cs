using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ResponseVerificationTests
    {
        [Fact(DisplayName = "测试用例：验证响应签名（基于 RSA）")]
        public async Task TestVerifyResponseSignatureUseRSA()
        {
            await TestClients.InitializeCertificateManagerAsync();

            var request = new Models.QueryCertificatesRequest() { AlgorithmType = "RSA" };
            var response = await TestClients.InstanceUseRSA.ExecuteQueryCertificatesAsync(request);
            Assert.True(response.GetRawStatus() == 200);
            Assert.True(response.GetRawHeaders().Any());
            Assert.True(response.GetRawBytes().Any());
            Assert.True(TestClients.InstanceUseRSA.VerifyResponseSignature(response));
            Assert.NotNull(response.WechatpayRequestId);
            Assert.NotNull(response.WechatpayNonce);
            Assert.NotNull(response.WechatpayTimestamp);
            Assert.NotNull(response.WechatpaySignature);
            Assert.NotNull(response.WechatpaySignatureType);
            Assert.NotNull(response.WechatpaySerialNumber);
        }

        [Fact(DisplayName = "测试用例：验证响应签名（基于 SM2）")]
        public async Task TestVerifyResponseSignatureUseSM2()
        {
            await TestClients.InitializeCertificateManagerAsync();

            var request = new Models.QueryCertificatesRequest() { AlgorithmType = "SM2" };
            var response = await TestClients.InstanceUseSM2.ExecuteQueryCertificatesAsync(request);
            Assert.True(response.GetRawStatus() == 200);
            Assert.True(response.GetRawHeaders().Any());
            Assert.True(response.GetRawBytes().Any());
            Assert.True(TestClients.InstanceUseSM2.VerifyResponseSignature(response));
            Assert.NotNull(response.WechatpayRequestId);
            Assert.NotNull(response.WechatpayNonce);
            Assert.NotNull(response.WechatpayTimestamp);
            Assert.NotNull(response.WechatpaySignature);
            Assert.NotNull(response.WechatpaySignatureType);
            Assert.NotNull(response.WechatpaySerialNumber);
        }
    }
}
