using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayResponseVerificationTests
    {
        [Fact(DisplayName = "验证响应签名")]
        public async Task VerifyResponseSignatureTest()
        {
            var request = new Models.QueryCertificatesRequest();
            var response = await TestClients.Instance.ExecuteQueryCertificatesAsync(request);

            Assert.NotNull(response.WechatpayRequestId);
            Assert.NotNull(response.WechatpayTimestamp);
            Assert.NotNull(response.WechatpayNonce);
            Assert.NotNull(response.WechatpayCertSerialNumber);
            Assert.NotNull(response.WechatpaySignature);

            TestClients.Instance.DecryptResponseEncryptedData(ref response);
            foreach (var certificateModel in response.CertificateList)
            {
                TestClients.GlobalCertificateManager.AddEntry(new Settings.CertificateEntry(certificateModel));
            }

            Assert.True(TestClients.Instance.VerifyResponseSignature(response));
        }
    }
}
