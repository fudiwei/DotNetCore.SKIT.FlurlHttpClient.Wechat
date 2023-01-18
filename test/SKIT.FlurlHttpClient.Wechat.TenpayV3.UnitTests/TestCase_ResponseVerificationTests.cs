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

            var request1 = new Models.QueryCertificatesRequest() { AlgorithmType = "RSA" };
            var response1 = await TestClients.InstanceUseRSA.ExecuteQueryCertificatesAsync(request1);
            Assert.True(response1.RawStatus == 200);
            Assert.True(response1.RawHeaders.Count > 0);
            Assert.True(response1.RawBytes.Length > 0);
            Assert.True(TestClients.InstanceUseRSA.VerifyResponseSignature(response1));
            Assert.NotNull(response1.WechatpayRequestId);
            Assert.NotNull(response1.WechatpayNonce);
            Assert.NotNull(response1.WechatpayTimestamp);
            Assert.NotNull(response1.WechatpaySignature);
            Assert.NotNull(response1.WechatpaySignatureType);
            Assert.NotNull(response1.WechatpayCertificateSerialNumber);

            var request2 = new Models.QueryCertificatesRequest() { AlgorithmType = "SM2" };
            var response2 = await TestClients.InstanceUseSM2.ExecuteQueryCertificatesAsync(request2);
            Assert.True(response2.RawStatus == 200);
            Assert.True(response2.RawHeaders.Count > 0);
            Assert.True(response2.RawBytes.Length > 0);
            Assert.True(TestClients.InstanceUseSM2.VerifyResponseSignature(response2));
            Assert.NotNull(response2.WechatpayRequestId);
            Assert.NotNull(response2.WechatpayNonce);
            Assert.NotNull(response2.WechatpayTimestamp);
            Assert.NotNull(response2.WechatpaySignature);
            Assert.NotNull(response2.WechatpaySignatureType);
            Assert.NotNull(response2.WechatpayCertificateSerialNumber);
        }
    }
}
