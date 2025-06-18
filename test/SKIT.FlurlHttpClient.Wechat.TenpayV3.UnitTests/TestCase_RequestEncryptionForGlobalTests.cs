using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models;

    public partial class TestCase_RequestEncryptionForGlobalTests
    {
        // 此处测试的 RSA 证书/公钥/私钥是自签名生成的，仅供执行 RSA 相关的单元测试，不能用于调用微信支付 API。
        private const string RSA_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIIFRzCCAy8CFDBQ9y4tzgPn7+SVV90jHRdmSa+9MA0GCSqGSIb3DQEBCwUAMGAx\nCzAJBgNVBAYTAkNOMREwDwYDVQQIDAhTaGFuZ2hhaTERMA8GA1UEBwwIU2hhbmdo\nYWkxDTALBgNVBAoMBFNLSVQxDTALBgNVBAsMBFNLSVQxDTALBgNVBAMMBFNLSVQw\nHhcNMjExMTI1MTgzNzQ4WhcNMjExMjI1MTgzNzQ4WjBgMQswCQYDVQQGEwJDTjER\nMA8GA1UECAwIU2hhbmdoYWkxETAPBgNVBAcMCFNoYW5naGFpMQ0wCwYDVQQKDART\nS0lUMQ0wCwYDVQQLDARTS0lUMQ0wCwYDVQQDDARTS0lUMIICIjANBgkqhkiG9w0B\nAQEFAAOCAg8AMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJ\nJaA+jm4DCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4\nay7KER0zo87zqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhl\nCudWCEWrNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2\nOG1Sn1vaDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQ\nfDLGnU7FuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIo\nxp5gt410rfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LI\nKw8oyeieqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+\n1wD9TLtGh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6H\nh/nFIkc1rekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj\n9xHSI8ejP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz\n+7cCAwEAATANBgkqhkiG9w0BAQsFAAOCAgEAVTS6oMfDA3XTwEel0BvaXMCdo7yM\ns5ueM87151eywnPlConYDXeqhfF0OCSBnY2g7Fpmn+YAUoa/L+FNOx/gMC9QV/lP\nHhhAcWpiCRy52RX/IyTDxFD6OqtH0BaBtDTb+QBXZuFypMUkPy6EUYs5Cl9qYepy\nHcgGVomx7tcwWcvI4o/KZtj8hXC5wu/k4Y0GGUriTt8xmnJ+RTRedZ6hzAFVHtXm\n/YIT9Lc1IIYZuHVyCbX/HXwa0E4r8lghwZRg94HUvpbfabNA3obt5auwtJUfW1tK\n2ERgFrtBRBWf9EGb8TstXqksqYZ04U4OjLm/3ZJhSSYKNbriRLlSEzAlHikNVW+t\n6cTh+sasrGt/qNIRMs5PiipwmV/T3z1LbyoiU7fXZ4GqiWBnZARFC9KiPPTzLszh\nBKJGYHaC8wkGb3WfNWFBqVRfFL8kdME+shLB8/ETQ31gIFeudnW1QlujJ7ZSZtwz\nxT3HxzZIIbNEqLFP+d37kmuKjRmI4KWc+pKOUw9BOl4g/TJH6ySljSNs8LSDWwQY\n76Dsnr+ovz8ZVLNUCmedZCyumeJo2tLkJmsPo5GuMnXpL94mhqpCoUS4l4JbJl44\nT2lmqp1Ueoz+Qlkqyt2lj3heTv9bvB7NO9KHTsDy1hhWHOG1QyXzajyWETU+1XdW\nx1hGvYxtpQPLUE8=\n-----END CERTIFICATE-----";
        private const string RSA_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\n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\nhpUq0eKgdGHc2R4r57soRvGoGy2DtA==\n-----END PRIVATE KEY-----";
        
        private const string MOCK_CERT_SN = "f2122a10319b84c2adbf83330411d7b3";
        private const string MOCK_PLAIN_STR = "U0tJVC5GbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYz";

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /customs/verify-certificate）")]
        public async Task TestEncryptRequestSensitiveProperty_VerifyCustomsCertificateRequest()
        {
            static VerifyCustomsCertificateRequest GenerateMockRequestModel()
            {
                return new VerifyCustomsCertificateRequest()
                {
                    CertificateId = MOCK_PLAIN_STR,
                    CertificateName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(VerifyCustomsCertificateRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.CertificateId!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.CertificateName!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.CertificateId!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.CertificateName!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher, Utilities.RSAUtility.PADDING_MODE_PKCS1)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteVerifyCustomsCertificateAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher, Utilities.RSAUtility.PADDING_MODE_PKCS1)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /merchants）")]
        public async Task TestEncryptRequestSensitiveProperty_AddSubMerchantRequest()
        {
            static AddSubMerchantRequest GenerateMockRequestModel()
            {
                return new AddSubMerchantRequest()
                {
                    Contact = new AddSubMerchantRequest.Types.Contact()
                    {
                        ContactName = MOCK_PLAIN_STR,
                        MobileNumber = MOCK_PLAIN_STR,
                        Email = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(AddSubMerchantRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.ContactName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.MobileNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.Email!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.ContactName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.MobileNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.Email!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher, Utilities.RSAUtility.PADDING_MODE_PKCS1)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteAddSubMerchantAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher, Utilities.RSAUtility.PADDING_MODE_PKCS1)!);
                }
            }
        }
    }

    partial class TestCase_RequestEncryptionForGlobalTests
    {
        public class MockHttpClient : HttpClient
        {
            public MockHttpClient()
                : base(new MockHttpMessageHandler(new HttpClientHandler()))
            {
            }
        }

        public class MockHttpMessageHandler : DelegatingHandler
        {
            public MockHttpMessageHandler(HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var resp = new HttpResponseMessage
                {
                    RequestMessage = request,
                    StatusCode = HttpStatusCode.NoContent,
                    Content = new ByteArrayContent(Array.Empty<byte>()),
                };
                return Task.FromResult(resp);
            }
        }

        private static WechatTenpayGlobalClient CreateMockClientUseRSA(bool autoEncrypt)
        {
            var manager = new Settings.InMemoryCertificateManager();
            manager.AddEntry(new Settings.CertificateEntry(
                algorithmType: Settings.CertificateEntry.ALGORITHM_TYPE_RSA,
                serialNumber: "OBSOLETED1",
                certificate: "-----BEGIN CERTIFICATE----------END CERTIFICATE-----",
                effectiveTime: DateTimeOffset.Now.AddSeconds(-1),
                expireTime: DateTimeOffset.Now.AddSeconds(-1)
            ));
            manager.AddEntry(new Settings.CertificateEntry(
                algorithmType: Settings.CertificateEntry.ALGORITHM_TYPE_RSA,
                serialNumber: MOCK_CERT_SN,
                certificate: RSA_PEM_CERTIFICATE,
                effectiveTime: DateTimeOffset.MinValue, // 为便于测试，直接使用最小值、而非实际证书的生效时间
                expireTime: DateTimeOffset.MaxValue     // 为便于测试，直接使用最大值、而非实际证书的过期时间
            ));
            manager.AddEntry(new Settings.CertificateEntry(
                algorithmType: Settings.CertificateEntry.ALGORITHM_TYPE_RSA,
                serialNumber: "OBSOLETED2",
                certificate: "-----BEGIN CERTIFICATE----------END CERTIFICATE-----",
                effectiveTime: DateTimeOffset.Now.AddSeconds(-1),
                expireTime: DateTimeOffset.Now.AddSeconds(-1)
            ));

            var client = new WechatTenpayGlobalClient(new WechatTenpayGlobalClientOptions()
            {
                MerchantId = DateTimeOffset.Now.ToUnixTimeSeconds().ToString(),
                MerchantCertificateSerialNumber = Guid.NewGuid().ToString("N"),
                MerchantCertificatePrivateKey = RSA_PEM_PRIVATE_KEY,
                MerchantV3Secret = Guid.NewGuid().ToString("N"),
                PlatformCertificateManager = manager,
                AutoEncryptRequestSensitiveProperty = autoEncrypt
            }, new MockHttpClient());
            return client;
        }
    }
}
