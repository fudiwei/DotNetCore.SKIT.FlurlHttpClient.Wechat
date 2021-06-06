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

            TestClients.Instance.DecryptResponseEncryptedData(response);
            var certificateModel = response.CertificateList.SingleOrDefault(e => e.SerialNumber == response.WechatpayCertSerialNumber);
            Assert.NotNull(certificateModel);

            // 通过证书验证签名
            Assert.True(TestClients.Instance.VerifyResponseSignatureByCertificate(response, certificate: certificateModel.EncryptCertificate.CipherText));
            // 通过公钥验证签名
            Assert.True(TestClients.Instance.VerifyResponseSignature(response, publicKey: Utilities.RSAUtility.ExportPublicKey(certificateModel.EncryptCertificate.CipherText)));
        }
    }
}
