using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayExecuteCertificatesTests
    {
        [Fact(DisplayName = "[GET] /certificates")]
        public async Task QueryCertificatesTest()
        {
            var request = new Models.QueryCertificatesRequest();
            var response = await TestClients.Instance.ExecuteQueryCertificatesAsync(request);

            Assert.NotEmpty(response.WechatpayRequestId);
            Assert.NotEmpty(response.WechatpayCertSerialNumber);
            Assert.NotEmpty(response.WechatpayTimestamp);
            Assert.NotEmpty(response.WechatpayNonce);
            Assert.NotEmpty(response.WechatpaySignature);
            Assert.True(response.CertificateList.All(e => e.SerialNumber != null));
            Assert.True(response.CertificateList.All(e => e.EncryptCertificate != null));
            Assert.True(response.CertificateList.All(e => e.EffectiveTime < DateTimeOffset.Now));
            Assert.True(response.CertificateList.All(e => e.ExpireTime > DateTimeOffset.Now));
        }
    }
}
