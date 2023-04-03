using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http.Configuration;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public partial class TestCase_ResponseDecryptionTests
    {
        // 此处测试的 RSA/SM2 证书/公钥/私钥是自签名生成的，仅供执行 RSA/SM2 相关的单元测试，不能用于调用微信支付 API。
        private const string RSA_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIIFRzCCAy8CFDBQ9y4tzgPn7+SVV90jHRdmSa+9MA0GCSqGSIb3DQEBCwUAMGAx\nCzAJBgNVBAYTAkNOMREwDwYDVQQIDAhTaGFuZ2hhaTERMA8GA1UEBwwIU2hhbmdo\nYWkxDTALBgNVBAoMBFNLSVQxDTALBgNVBAsMBFNLSVQxDTALBgNVBAMMBFNLSVQw\nHhcNMjExMTI1MTgzNzQ4WhcNMjExMjI1MTgzNzQ4WjBgMQswCQYDVQQGEwJDTjER\nMA8GA1UECAwIU2hhbmdoYWkxETAPBgNVBAcMCFNoYW5naGFpMQ0wCwYDVQQKDART\nS0lUMQ0wCwYDVQQLDARTS0lUMQ0wCwYDVQQDDARTS0lUMIICIjANBgkqhkiG9w0B\nAQEFAAOCAg8AMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJ\nJaA+jm4DCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4\nay7KER0zo87zqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhl\nCudWCEWrNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2\nOG1Sn1vaDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQ\nfDLGnU7FuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIo\nxp5gt410rfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LI\nKw8oyeieqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+\n1wD9TLtGh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6H\nh/nFIkc1rekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj\n9xHSI8ejP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz\n+7cCAwEAATANBgkqhkiG9w0BAQsFAAOCAgEAVTS6oMfDA3XTwEel0BvaXMCdo7yM\ns5ueM87151eywnPlConYDXeqhfF0OCSBnY2g7Fpmn+YAUoa/L+FNOx/gMC9QV/lP\nHhhAcWpiCRy52RX/IyTDxFD6OqtH0BaBtDTb+QBXZuFypMUkPy6EUYs5Cl9qYepy\nHcgGVomx7tcwWcvI4o/KZtj8hXC5wu/k4Y0GGUriTt8xmnJ+RTRedZ6hzAFVHtXm\n/YIT9Lc1IIYZuHVyCbX/HXwa0E4r8lghwZRg94HUvpbfabNA3obt5auwtJUfW1tK\n2ERgFrtBRBWf9EGb8TstXqksqYZ04U4OjLm/3ZJhSSYKNbriRLlSEzAlHikNVW+t\n6cTh+sasrGt/qNIRMs5PiipwmV/T3z1LbyoiU7fXZ4GqiWBnZARFC9KiPPTzLszh\nBKJGYHaC8wkGb3WfNWFBqVRfFL8kdME+shLB8/ETQ31gIFeudnW1QlujJ7ZSZtwz\nxT3HxzZIIbNEqLFP+d37kmuKjRmI4KWc+pKOUw9BOl4g/TJH6ySljSNs8LSDWwQY\n76Dsnr+ovz8ZVLNUCmedZCyumeJo2tLkJmsPo5GuMnXpL94mhqpCoUS4l4JbJl44\nT2lmqp1Ueoz+Qlkqyt2lj3heTv9bvB7NO9KHTsDy1hhWHOG1QyXzajyWETU+1XdW\nx1hGvYxtpQPLUE8=\n-----END CERTIFICATE-----";
        private const string RSA_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\n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\nhpUq0eKgdGHc2R4r57soRvGoGy2DtA==\n-----END PRIVATE KEY-----";
        private const string SM2_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIICNzCCAdygAwIBAgIJAOWoGwJCnY0IMAoGCCqBHM9VAYN1MGcxCzAJBgNVBAYT\nAkNOMRAwDgYDVQQIDAdCZWlqaW5nMRAwDgYDVQQHDAdIYWlEaWFuMRMwEQYDVQQK\nDApHTUNlcnQub3JnMR8wHQYDVQQDDBZHTUNlcnQgR00gUm9vdCBDQSAtIDAxMB4X\nDTIyMTEwOTEzMTIyMFoXDTIzMTEwOTEzMTIyMFowSzEtMCsGA1UEAwwkU0tJVC5G\nbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYzMQ0wCwYDVQQKDARTS0lUMQsw\nCQYDVQQGEwJDTjBZMBMGByqGSM49AgEGCCqBHM9VAYItA0IABMXP1hZc2zBzreRN\nZgOR9hklE01tw10RDUfj176EXcVoVOvITMENJ3HREQtDPlOfz8i1SXCQEwclYyxI\n2KcTdKqjgYwwgYkwDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA/gwLAYJYIZIAYb4\nQgENBB8WHUdNQ2VydC5vcmcgU2lnbmVkIENlcnRpZmljYXRlMB0GA1UdDgQWBBRj\nIhoxmSgP84XT/scjkQNSWylMFTAfBgNVHSMEGDAWgBR/Wl47AIRZKg+YvqEObzmV\nQxBNBzAKBggqgRzPVQGDdQNJADBGAiEAnXykM0qDOWay2EMB6+c6YJ7h4n7Wbju7\nXuT5RkuM/3ICIQDAA3sLba/dQMhmKkCoJl31iZwYKz7NP+0aq6NhWDommQ==\n-----END CERTIFICATE-----";
        private const string SM2_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\nMIGTAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBHkwdwIBAQQg3WePog9R4UV/EVlk\nCw8YHu+rXC/imiB89jFmaAPeXz6gCgYIKoEcz1UBgi2hRANCAATFz9YWXNswc63k\nTWYDkfYZJRNNbcNdEQ1H49e+hF3FaFTryEzBDSdx0RELQz5Tn8/ItUlwkBMHJWMs\nSNinE3Sq\n-----END PRIVATE KEY-----";

        private const string MOCK_PLAIN_STR = "U0tJVC5GbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYz";

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /bill/sub-merchant-fundflowbill）")]
        public async Task TestDecryptResponseSensitiveProperty_GetBillSubMerchantFundflowBillResponse()
        {
            static Models.GetBillSubMerchantFundflowBillResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetBillSubMerchantFundflowBillResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    DownloadBillList = new Models.GetBillSubMerchantFundflowBillResponse.Types.DownloadBill[]
                    {
                        new Models.GetBillSubMerchantFundflowBillResponse.Types.DownloadBill()
                        {
                            EncryptKey = encryptor.Invoke(MOCK_PLAIN_STR)
                        }
                    }
                };
            }

            static void AssertMockResponseModel(Models.GetBillSubMerchantFundflowBillResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.DownloadBillList![0].EncryptKey!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetBillSubMerchantFundflowBillAsync(new Models.GetBillSubMerchantFundflowBillRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetBillSubMerchantFundflowBillAsync(new Models.GetBillSubMerchantFundflowBillRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /certificates）")]
        public async Task TestDecryptResponseSensitiveProperty_QueryCertificatesResponse()
        {
            using (var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantRSACertificateSerialNumber,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantRSACertificatePrivateKey
            }))
            {
                var response = await client.ExecuteQueryCertificatesAsync(new Models.QueryCertificatesRequest());
                client.DecryptResponseSensitiveProperty(response);

                Assert.All(response.CertificateList, (e) =>
                {
                    Assert.StartsWith("-----BEGIN CERTIFICATE-----", e.EncryptCertificate.CipherText);
                    Assert.EndsWith("-----END CERTIFICATE-----", e.EncryptCertificate.CipherText);
                });
            }

            using (var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantSM2CertificateSerialNumber!,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantSM2CertificatePrivateKey!,
                SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3
            }))
            {
                var response = await client.ExecuteQueryCertificatesAsync(new Models.QueryCertificatesRequest());
                client.DecryptResponseSensitiveProperty(response);

                Assert.All(response.CertificateList, (e) =>
                {
                    Assert.StartsWith("-----BEGIN CERTIFICATE-----", e.EncryptCertificate.CipherText);
                    Assert.EndsWith("-----END CERTIFICATE-----", e.EncryptCertificate.CipherText);
                });
            }

            using (var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantRSACertificateSerialNumber,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantRSACertificatePrivateKey,
                AutoDecryptResponseSensitiveProperty = true
            }))
            {
                var response = await client.ExecuteQueryCertificatesAsync(new Models.QueryCertificatesRequest());

                Assert.All(response.CertificateList, (e) =>
                {
                    Assert.StartsWith("-----BEGIN CERTIFICATE-----", e.EncryptCertificate.CipherText);
                    Assert.EndsWith("-----END CERTIFICATE-----", e.EncryptCertificate.CipherText);
                });
            }

            using (var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantSM2CertificateSerialNumber!,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantSM2CertificatePrivateKey!,
                SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3,
                AutoDecryptResponseSensitiveProperty = true
            }))
            {
                var response = await client.ExecuteQueryCertificatesAsync(new Models.QueryCertificatesRequest());

                Assert.All(response.CertificateList, (e) =>
                {
                    Assert.StartsWith("-----BEGIN CERTIFICATE-----", e.EncryptCertificate.CipherText);
                    Assert.EndsWith("-----END CERTIFICATE-----", e.EncryptCertificate.CipherText);
                });
            }
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /ecommerce/applyments/out-request-no/{out_request_no}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetEcommerceApplymentByOutRequestNumberResponse()
        {
            static Models.GetEcommerceApplymentByOutRequestNumberResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetEcommerceApplymentByOutRequestNumberResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    AccountValidation = new Models.GetEcommerceApplymentByOutRequestNumberResponse.Types.AccountValidation()
                    {
                        AccountName = encryptor.Invoke(MOCK_PLAIN_STR),
                        AccountNumber = encryptor.Invoke(MOCK_PLAIN_STR),
                        Deadline = DateTimeOffset.Now
                    }
                };
            }

            static void AssertMockResponseModel(Models.GetEcommerceApplymentByOutRequestNumberResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.AccountValidation!.AccountName!);
                Assert.Equal(MOCK_PLAIN_STR, response.AccountValidation!.AccountNumber!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetEcommerceApplymentByOutRequestNumberAsync(new Models.GetEcommerceApplymentByOutRequestNumberRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetEcommerceApplymentByOutRequestNumberAsync(new Models.GetEcommerceApplymentByOutRequestNumberRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /ecommerce/bill/fundflowbill）")]
        public async Task TestDecryptResponseSensitiveProperty_GetEcommerceBillFundflowBillResponse()
        {
            static Models.GetEcommerceBillFundflowBillResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetEcommerceBillFundflowBillResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    DownloadBillList = new Models.GetEcommerceBillFundflowBillResponse.Types.DownloadBill[]
                    {
                        new Models.GetEcommerceBillFundflowBillResponse.Types.DownloadBill()
                        {
                            EncryptKey = encryptor.Invoke(MOCK_PLAIN_STR)
                        }
                    }
                };
            }

            static void AssertMockResponseModel(Models.GetEcommerceBillFundflowBillResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.DownloadBillList![0].EncryptKey!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetEcommerceBillFundflowBillAsync(new Models.GetEcommerceBillFundflowBillRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetEcommerceBillFundflowBillAsync(new Models.GetEcommerceBillFundflowBillRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /merchants/{sub_mchid}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetHKSubMerchantResponse()
        {
            static Models.GetHKSubMerchantResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetHKSubMerchantResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    Contact = new Models.GetHKSubMerchantResponse.Types.Contact
                    {
                        ContactName = encryptor.Invoke(MOCK_PLAIN_STR),
                        MobileNumber = encryptor.Invoke(MOCK_PLAIN_STR),
                        Email = encryptor.Invoke(MOCK_PLAIN_STR)
                    }
                };
            }

            static void AssertMockResponseModel(Models.GetHKSubMerchantResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.Contact!.ContactName!);
                Assert.Equal(MOCK_PLAIN_STR, response.Contact!.MobileNumber!);
                Assert.Equal(MOCK_PLAIN_STR, response.Contact!.Email!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain, "Pkcs1Padding"));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain, "Pkcs1Padding"))
                )
            ).ExecuteGetHKSubMerchantAsync(new Models.GetHKSubMerchantRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetHKSubMerchantAsync(new Models.GetHKSubMerchantRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /merchant-service/complaints-v2）")]
        public async Task TestDecryptResponseSensitiveProperty_QueryMerchantServiceComplaintsResponse()
        {
            static Models.QueryMerchantServiceComplaintsResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.QueryMerchantServiceComplaintsResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    ComplaintList = new Models.QueryMerchantServiceComplaintsResponse.Types.Complaint[]
                    {
                        new Models.QueryMerchantServiceComplaintsResponse.Types.Complaint()
                        {
                            PayerPhone = encryptor.Invoke(MOCK_PLAIN_STR)
                        }
                    }
                };
            }

            static void AssertMockResponseModel(Models.QueryMerchantServiceComplaintsResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.ComplaintList![0].PayerPhone!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteQueryMerchantServiceComplaintsAsync(new Models.QueryMerchantServiceComplaintsRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteQueryMerchantServiceComplaintsAsync(new Models.QueryMerchantServiceComplaintsRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /merchant-service/complaints-v2/{complaint_id}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetMerchantServiceComplaintByComplaintIdResponse()
        {
            static Models.GetMerchantServiceComplaintByComplaintIdResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetMerchantServiceComplaintByComplaintIdResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    PayerPhone = encryptor.Invoke(MOCK_PLAIN_STR)
                };
            }

            static void AssertMockResponseModel(Models.GetMerchantServiceComplaintByComplaintIdResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.PayerPhone!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetMerchantServiceComplaintByComplaintIdAsync(new Models.GetMerchantServiceComplaintByComplaintIdRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetMerchantServiceComplaintByComplaintIdAsync(new Models.GetMerchantServiceComplaintByComplaintIdRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetNewTaxControlFapiaoApplicationByFapiaoApplyId()
        {
            static Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    FapiaoList = new Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse.Types.Fapiao[]
                    {
                        new Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse.Types.Fapiao()
                        {
                            Buyer = new Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse.Types.Fapiao.Types.Buyer()
                            {
                                UserMobileNumber = encryptor.Invoke(MOCK_PLAIN_STR),
                                UserEmail = encryptor.Invoke(MOCK_PLAIN_STR)
                            }
                        }
                    }
                };
            }

            static void AssertMockResponseModel(Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.FapiaoList[0]!.Buyer!.UserMobileNumber!);
                Assert.Equal(MOCK_PLAIN_STR, response.FapiaoList[0]!.Buyer!.UserEmail!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetNewTaxControlFapiaoApplicationByFapiaoApplyIdAsync(new Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetNewTaxControlFapiaoApplicationByFapiaoApplyIdAsync(new Models.GetNewTaxControlFapiaoApplicationByFapiaoApplyIdRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /new-tax-control-fapiao/user-title）")]
        public async Task TestDecryptResponseSensitiveProperty_GetNewTaxControlFapiaoUserTitle()
        {
            static Models.GetNewTaxControlFapiaoUserTitleResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetNewTaxControlFapiaoUserTitleResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    UserMobileNumber = encryptor.Invoke(MOCK_PLAIN_STR),
                    UserEmail = encryptor.Invoke(MOCK_PLAIN_STR)
                };
            }

            static void AssertMockResponseModel(Models.GetNewTaxControlFapiaoUserTitleResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.UserMobileNumber!);
                Assert.Equal(MOCK_PLAIN_STR, response.UserEmail!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetNewTaxControlFapiaoUserTitleAsync(new Models.GetNewTaxControlFapiaoUserTitleRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetNewTaxControlFapiaoUserTitleAsync(new Models.GetNewTaxControlFapiaoUserTitleRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /partner-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetPartnerTransferBatchDetailByDetailIdResponse()
        {
            static Models.GetPartnerTransferBatchDetailByDetailIdResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetPartnerTransferBatchDetailByDetailIdResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    UserName = encryptor.Invoke(MOCK_PLAIN_STR)
                };
            }

            static void AssertMockResponseModel(Models.GetPartnerTransferBatchDetailByDetailIdResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.UserName!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetPartnerTransferBatchDetailByDetailIdAsync(new Models.GetPartnerTransferBatchDetailByDetailIdRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetPartnerTransferBatchDetailByDetailIdAsync(new Models.GetPartnerTransferBatchDetailByDetailIdRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /partner-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetPartnerTransferBatchDetailByOutDetailNumberResponse()
        {
            static Models.GetPartnerTransferBatchDetailByOutDetailNumberResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetPartnerTransferBatchDetailByOutDetailNumberResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    UserName = encryptor.Invoke(MOCK_PLAIN_STR)
                };
            }

            static void AssertMockResponseModel(Models.GetPartnerTransferBatchDetailByOutDetailNumberResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.UserName!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetPartnerTransferBatchDetailByOutDetailNumberAsync(new Models.GetPartnerTransferBatchDetailByOutDetailNumberRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetPartnerTransferBatchDetailByOutDetailNumberAsync(new Models.GetPartnerTransferBatchDetailByOutDetailNumberRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /payscore/merchant-bill）")]
        public async Task TestDecryptResponseSensitiveProperty_GetPayScoreMerchantBillResponse()
        {
            static Models.GetPayScoreMerchantBillResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetPayScoreMerchantBillResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    DownloadBillList = new Models.GetPayScoreMerchantBillResponse.Types.DownloadBill[]
                    {
                        new Models.GetPayScoreMerchantBillResponse.Types.DownloadBill()
                        {
                            EncryptKey = encryptor.Invoke(MOCK_PLAIN_STR)
                        }
                    }
                };
            }

            static void AssertMockResponseModel(Models.GetPayScoreMerchantBillResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.DownloadBillList![0].EncryptKey!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetPayScoreMerchantBillAsync(new Models.GetPayScoreMerchantBillRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetPayScoreMerchantBillAsync(new Models.GetPayScoreMerchantBillRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /smartguide/guides）")]
        public async Task TestDecryptResponseSensitiveProperty_QuerySmartGuidesResponse()
        {
            static Models.QuerySmartGuidesResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.QuerySmartGuidesResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    GuideList = new Models.QuerySmartGuidesResponse.Types.Guide[]
                    {
                        new Models.QuerySmartGuidesResponse.Types.Guide()
                        {
                            UserName = encryptor.Invoke(MOCK_PLAIN_STR),
                            UserMobile = encryptor.Invoke(MOCK_PLAIN_STR)
                        }
                    }
                };
            }

            static void AssertMockResponseModel(Models.QuerySmartGuidesResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.GuideList![0].UserName!);
                Assert.Equal(MOCK_PLAIN_STR, response.GuideList![0].UserMobile!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteQuerySmartGuidesAsync(new Models.QuerySmartGuidesRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteQuerySmartGuidesAsync(new Models.QuerySmartGuidesRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetTransferBatchDetailByOutDetailNumberResponse()
        {
            static Models.GetTransferBatchDetailByOutDetailNumberResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetTransferBatchDetailByOutDetailNumberResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    UserName = encryptor.Invoke(MOCK_PLAIN_STR)
                };
            }

            static void AssertMockResponseModel(Models.GetTransferBatchDetailByOutDetailNumberResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.UserName!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetTransferBatchDetailByOutDetailNumberAsync(new Models.GetTransferBatchDetailByOutDetailNumberRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetTransferBatchDetailByOutDetailNumberAsync(new Models.GetTransferBatchDetailByOutDetailNumberRequest());
            AssertMockResponseModel(resB2);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id}）")]
        public async Task TestDecryptResponseSensitiveProperty_GetTransferBatchDetailByDetailIdResponse()
        {
            static Models.GetTransferBatchDetailByDetailIdResponse GenerateMockResponseModel(Func<string, string> encryptor)
            {
                return new Models.GetTransferBatchDetailByDetailIdResponse()
                {
                    RawStatus = (int)HttpStatusCode.OK,
                    UserName = encryptor.Invoke(MOCK_PLAIN_STR)
                };
            }

            static void AssertMockResponseModel(Models.GetTransferBatchDetailByDetailIdResponse response)
            {
                Assert.Equal(MOCK_PLAIN_STR, response.UserName!);
            }

            var resA1 = GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain));
            CreateMockClientUseRSA(autoDecrypt: false).DecryptResponseSensitiveProperty(resA1);
            AssertMockResponseModel(resA1);

            var resA2 = GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain));
            CreateMockClientUseSM2(autoDecrypt: false).DecryptResponseSensitiveProperty(resA2);
            AssertMockResponseModel(resA2);

            var resB1 = await CreateMockClientUseRSA(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetTransferBatchDetailByDetailIdAsync(new Models.GetTransferBatchDetailByDetailIdRequest());
            AssertMockResponseModel(resB1);

            var resB2 = await CreateMockClientUseSM2(
                autoDecrypt: true,
                mockResponseContent: new FlurlSystemTextJsonSerializer().Serialize(
                    GenerateMockResponseModel((plain) => Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plain))
                )
            ).ExecuteGetTransferBatchDetailByDetailIdAsync(new Models.GetTransferBatchDetailByDetailIdRequest());
            AssertMockResponseModel(resB2);
        }
    }

    partial class TestCase_ResponseDecryptionTests
    {
        public class MockHttpClientFactory : DefaultHttpClientFactory
        {
            private readonly string? _mockResponseContent;

            public MockHttpClientFactory(string? mockResponseContent)
            {
                _mockResponseContent = mockResponseContent;
            }

            public override HttpMessageHandler CreateMessageHandler()
            {
                return new MockHttpMessageHandler(base.CreateMessageHandler(), _mockResponseContent);
            }
        }

        public class MockHttpMessageHandler : DelegatingHandler
        {
            private readonly string? _mockResponseContent;

            public MockHttpMessageHandler(HttpMessageHandler innerHandler, string? mockResponseContent)
                : base(innerHandler)
            {
                _mockResponseContent = mockResponseContent;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                bool hasContent = !string.IsNullOrEmpty(_mockResponseContent);
                var resp = new HttpResponseMessage
                {
                    StatusCode = hasContent ? HttpStatusCode.OK : HttpStatusCode.NoContent,
                    Content = hasContent ? new StringContent(_mockResponseContent!, Encoding.UTF8) : new ByteArrayContent(Array.Empty<byte>()),
                };
                resp.Headers.TryAddWithoutValidation("Content-Length", hasContent ? Encoding.UTF8.GetBytes(_mockResponseContent!).Length.ToString() : (0).ToString());
                return Task.FromResult(resp);
            }
        }

        private static WechatTenpayClient CreateMockClientUseRSA(bool autoDecrypt, string? mockResponseContent = null)
        {
            var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = DateTimeOffset.Now.ToUnixTimeSeconds().ToString(),
                MerchantCertificateSerialNumber = Guid.NewGuid().ToString("N"),
                MerchantCertificatePrivateKey = RSA_PEM_PRIVATE_KEY,
                MerchantV3Secret = Guid.NewGuid().ToString("N"),
                AutoDecryptResponseSensitiveProperty = autoDecrypt
            });
            client.Configure(settings => settings.FlurlHttpClientFactory = new MockHttpClientFactory(mockResponseContent));
            return client;
        }

        private static WechatTenpayClient CreateMockClientUseSM2(bool autoDecrypt, string? mockResponseContent = null)
        {
            var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = DateTimeOffset.Now.ToUnixTimeSeconds().ToString(),
                MerchantCertificateSerialNumber = Guid.NewGuid().ToString("N"),
                MerchantCertificatePrivateKey = SM2_PEM_PRIVATE_KEY,
                MerchantV3Secret = Guid.NewGuid().ToString("N"),
                SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3,
                AutoDecryptResponseSensitiveProperty = autoDecrypt
            });
            client.Configure(settings => settings.FlurlHttpClientFactory = new MockHttpClientFactory(mockResponseContent));
            return client;
        }
    }
}
