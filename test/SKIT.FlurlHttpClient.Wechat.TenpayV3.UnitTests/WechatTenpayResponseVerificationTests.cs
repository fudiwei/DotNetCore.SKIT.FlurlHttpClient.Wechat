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
            await TestClients.InitializeCertificateManagerAsync();

            var request = new Models.QueryCertificatesRequest();
            var response = await TestClients.Instance.ExecuteQueryCertificatesAsync(request);

            Assert.True(response.RawStatus == 200);
            Assert.True(response.RawHeaders.Count > 0);
            Assert.True(response.RawBytes.Length > 0);
            Assert.True(TestClients.Instance.VerifyResponseSignature(response));
        }
    }
}
