using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http.Configuration;
using Xunit;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public partial class TestCase_RequestEncryptionTests
    {
        // 此处测试的 RSA/SM2 证书/公钥/私钥是自签名生成的，仅供执行 RSA/SM2 相关的单元测试，不能用于调用微信支付 API。
        private const string RSA_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIIFRzCCAy8CFDBQ9y4tzgPn7+SVV90jHRdmSa+9MA0GCSqGSIb3DQEBCwUAMGAx\nCzAJBgNVBAYTAkNOMREwDwYDVQQIDAhTaGFuZ2hhaTERMA8GA1UEBwwIU2hhbmdo\nYWkxDTALBgNVBAoMBFNLSVQxDTALBgNVBAsMBFNLSVQxDTALBgNVBAMMBFNLSVQw\nHhcNMjExMTI1MTgzNzQ4WhcNMjExMjI1MTgzNzQ4WjBgMQswCQYDVQQGEwJDTjER\nMA8GA1UECAwIU2hhbmdoYWkxETAPBgNVBAcMCFNoYW5naGFpMQ0wCwYDVQQKDART\nS0lUMQ0wCwYDVQQLDARTS0lUMQ0wCwYDVQQDDARTS0lUMIICIjANBgkqhkiG9w0B\nAQEFAAOCAg8AMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJ\nJaA+jm4DCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4\nay7KER0zo87zqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhl\nCudWCEWrNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2\nOG1Sn1vaDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQ\nfDLGnU7FuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIo\nxp5gt410rfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LI\nKw8oyeieqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+\n1wD9TLtGh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6H\nh/nFIkc1rekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj\n9xHSI8ejP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz\n+7cCAwEAATANBgkqhkiG9w0BAQsFAAOCAgEAVTS6oMfDA3XTwEel0BvaXMCdo7yM\ns5ueM87151eywnPlConYDXeqhfF0OCSBnY2g7Fpmn+YAUoa/L+FNOx/gMC9QV/lP\nHhhAcWpiCRy52RX/IyTDxFD6OqtH0BaBtDTb+QBXZuFypMUkPy6EUYs5Cl9qYepy\nHcgGVomx7tcwWcvI4o/KZtj8hXC5wu/k4Y0GGUriTt8xmnJ+RTRedZ6hzAFVHtXm\n/YIT9Lc1IIYZuHVyCbX/HXwa0E4r8lghwZRg94HUvpbfabNA3obt5auwtJUfW1tK\n2ERgFrtBRBWf9EGb8TstXqksqYZ04U4OjLm/3ZJhSSYKNbriRLlSEzAlHikNVW+t\n6cTh+sasrGt/qNIRMs5PiipwmV/T3z1LbyoiU7fXZ4GqiWBnZARFC9KiPPTzLszh\nBKJGYHaC8wkGb3WfNWFBqVRfFL8kdME+shLB8/ETQ31gIFeudnW1QlujJ7ZSZtwz\nxT3HxzZIIbNEqLFP+d37kmuKjRmI4KWc+pKOUw9BOl4g/TJH6ySljSNs8LSDWwQY\n76Dsnr+ovz8ZVLNUCmedZCyumeJo2tLkJmsPo5GuMnXpL94mhqpCoUS4l4JbJl44\nT2lmqp1Ueoz+Qlkqyt2lj3heTv9bvB7NO9KHTsDy1hhWHOG1QyXzajyWETU+1XdW\nx1hGvYxtpQPLUE8=\n-----END CERTIFICATE-----";
        private const string RSA_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\nMIIJQgIBADANBgkqhkiG9w0BAQEFAASCCSwwggkoAgEAAoICAQDnYOzNRnM8o+jV\n30eLkeOW7s4g3AANp5eJ8Diu+YkloD6ObgMIzCsAzPJLXYSJbfXEIAXwtn/GSsUc\n7kJmC8rztj6Rj0OaG81foVViyfhrLsoRHTOjzvOpCML6eNS7Wti4qeKjsxhvfng+\nK3BDdJY2/apMJsI0JdM32klc2GUK51YIRas2thzj+ErPduq7UOOljSge64o+T+JG\nvZNNQgDBqE2Q1CF5A0HZryEvsvY4bVKfW9oNZ77lEliUxFnc2BgNOqjLwYyz7qrT\n3UxAwOVD3SO1b8kSgzkNTIjzN9B8MsadTsW5jSutn/7o5BP+jshJ/Q5HlMhJLSWq\ncM3e9VqmHR+0MZF0aomTZIkAcijGnmC3jXSt9ZL2SlIMUmzc++3iu01kFi+QYPyh\ntKb3VusCShfj67VjinWpmlYngsgrDyjJ6J6qUtm0X9UYo60rF78gqfwbChAkvHh1\nQYU6ozsc/BH1zKMxoLWjdXU1Ab7XAP1Mu0aHdZdQUlFgOZ49pKnf0YU+6lMyU9Fs\nPRErzQHrG/athPJjJ3yzYs3o/oeH+cUiRzWt6Qh/0mE/LRYrOtd2ad+NIco/GbPR\nZJg3wXEpqypwmGdw52EtPPNUSGP3EdIjx6M/Z8ni/4BGgPcZRE8P0fsoxrvGbNFI\nBnwDwsze690k2FsoHBaq+jjmdzP7twIDAQABAoICAQDTJ+hT2eRWxfs6G39uhyBd\nYOhqonvF+llYgAsq2/3mgZw1XX6Va8Ye/+prDxhiVyB/8P2a1OI884V5xpKAEGkS\nCxKEwmreXFsL1+9VrZ5xKo0sGytCZh6F98IA1X7G0LyRojB8VniJX7CahAf6944S\n92KQBpsa/h4JjcN/4NgtoDsqZ3I+BurMvY6AUTUc51ApiG3B8hECluKYzm98hSyt\nj0viTUWS638QCzxNDJSZoGNTnX6c1z4mTZzbf2nHGsqwYAUlligzGS97FC1/tspE\nKa9p6G9m3qyVT3B4DkrM3YXWj8nwcT4YQLhgj60TlfiBVVjPyJ8T8Qi7yCCJRf6H\nd8/YT9Nh/uaHh9DUmgiN6SL2v7kRnfJ9+5nXfyxjC/jiJjMwoFvSzkWYNdz0AOiw\nqVFVAzIBvNS4he6blXlpxvi8vtx4Bkg86uwUlauKtUbtRxy7PaUYJ966dgvYH6oB\nEqRPXqSc0d4GaY+RS6LzcXmwLYmsXwZV+GwY9Q8Y445vuP20Ae/dc2l9R19Dp90U\nYWKU49QgXIrGqZ0vL4StWuy10Y3tpBdW12qBpVGwUIxMhY2dAR5nWrXnqbqXZ3KK\novWPPKj0+SUN/RKglzNjezkvJqcfTHWn32+wqjTzAivYIYZhFtYRje95OzGnjp3q\nVQm/hXZGWaJdNCmu94oFcQKCAQEA/iRxbMxY3ZC2E3VD9PzTatRWxJ0ZgR2ZvXQZ\nDZe+Ut1bzuKerPQIkGNDAqRjicYSS6QbtopNbVjyNpz7lJduXXohpTSDrWlIjfto\n/dQ8AFHOEeM2ynp/s+Q8/fzXAbgmBmgFpGOf/bYzDWuweQ9G29msJ7G8py+Lo5RH\nb6ZmhvkGVez4m3mR7B3fbRMO/K/4fyRRJm40Nc3aAk+UbnhL/Nl8nMRC+bkjJv0N\nG4Pf6Fhf99sqJR7EbS2B5p9C+m6Du9zVC/zmIhOSg7Cg6/VGLdSX/el7QgL9r8Ld\n71a1Bn4hTeWnRgkyyC2c/oiCx2GcLFMNXZECIqUNhpZDsaNz/wKCAQEA6RHiywU+\niVyRW28RP3UvoKhm0RqWH8kFJ6SjATi0QDTNUAOEtTOXAmyc9FuxkBQjoIi8qVby\nYwZF9YFXb1o823J4EafEKX1D9gGHeV22FlzhMSBOzf0KTi1R9IAJoIScBIyNyamZ\nKwAfa7bLCbxNBiQG3JYmQqI3OE6VFFM7uuIWvZHF26Rt8HLKYXtRzZ/phO3mJ4Ke\nyQYfl+yF5PWueGpLJAjNYI3E2TxxudQMtYkWDV6o8OJrQ66bnUcHMxi1XPNYDlBM\nAQsGHIN7+qYx5EY7fHK1kzChYOoORsqjGwj9SSEdnNTM3uB6PLXnJsoG0NTaaoVo\nW5rfnCPjI0gYSQKCAQBlMj24BOad0zGtLdSRiNrmfwbN44B0WUUOm1wefX3boSkd\niD+GvuVqGRxlwO+hvK0sUXx3gzqxf+lyta+3y1S3BBrBndeRBYtOff2glRIPToOv\nu7nlhkGzb/6ZZER4+sqpYmJcww7CB/rsLSVoDx04DcTvSWbFa7k+uZx4aNoKhL5x\nGJslzZK9YmfFFwGwvKFGfz+Q/fDsO7vDj8ya8GvRkwh7o+rHZWEJ9Vlyy2AtNIOC\nPlLZ1RaCIszG+EPDVJ4///8Vdu5sQz7kEUECs/ft5+ldwcrCzk4V3pJg6zXKEA9S\n5U9mI+OEsiUBdXodylBVlfyMdWFUSkTIgq0R3vQhAoIBABtLb+7st00o3REDKdbv\np1s+PYRBg9FHHmZtHnXXKSzXwi+bqd/6obWz+JGZZ2sDIMT9HnMKbqpwIqNEuXOd\n8sCUYEFZD1z4gYv+09m/wsJNsEWrje8LsjhDkHR8xiPZQ9g4iaZTSU/C3OslZhPG\nzJJqh68vml11V9gtQ8I0mSsirR0YRD6bvBBLsS3HXmYhUxyxK6H25xeNswd8uJV+\nvCb388LNkRe8oo/6RytHDRH5cu6v5kMHkR5FBY5eshYmz56KFQbgGnaIzvdp4owR\nCIi+PNsvJ9qL+Go8Ht3lf0J8RAVbbndeaHu1eDtB5kcho7izJL0S0Izhz0we28vW\n9pkCggEAbxVbSvo1zwI6rJ5V5hNA3mLfyQfZbdGa3DvsJNpYkkKfcDDCY0A5c87v\naIXJs+Mv2Ec/jNlQnIgrAavrM4Q8QxsBCfQREfb2GK9xZPINAZ9BZAyMcqO5FIUG\n2b5SKxXWVaFpt52CsKXQIIJUy3VI9lyvKNQc9xKIXarYiMyC9X4/tVmqZqIJwPZZ\nZqWeptNm5dyIGHbKsxIXdYBgD8TKb22nFaKbRX7dB11zGfs3o5rOftWWew7/ha3Q\nePN9vy8x0PXfKzBbWNgOwu/uv4uQF0mrhHb+sn6N2XSj3v20nJz562ropN3tI8oe\nhpUq0eKgdGHc2R4r57soRvGoGy2DtA==\n-----END PRIVATE KEY-----";
        private const string SM2_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIICNzCCAdygAwIBAgIJAOWoGwJCnY0IMAoGCCqBHM9VAYN1MGcxCzAJBgNVBAYT\nAkNOMRAwDgYDVQQIDAdCZWlqaW5nMRAwDgYDVQQHDAdIYWlEaWFuMRMwEQYDVQQK\nDApHTUNlcnQub3JnMR8wHQYDVQQDDBZHTUNlcnQgR00gUm9vdCBDQSAtIDAxMB4X\nDTIyMTEwOTEzMTIyMFoXDTIzMTEwOTEzMTIyMFowSzEtMCsGA1UEAwwkU0tJVC5G\nbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYzMQ0wCwYDVQQKDARTS0lUMQsw\nCQYDVQQGEwJDTjBZMBMGByqGSM49AgEGCCqBHM9VAYItA0IABMXP1hZc2zBzreRN\nZgOR9hklE01tw10RDUfj176EXcVoVOvITMENJ3HREQtDPlOfz8i1SXCQEwclYyxI\n2KcTdKqjgYwwgYkwDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA/gwLAYJYIZIAYb4\nQgENBB8WHUdNQ2VydC5vcmcgU2lnbmVkIENlcnRpZmljYXRlMB0GA1UdDgQWBBRj\nIhoxmSgP84XT/scjkQNSWylMFTAfBgNVHSMEGDAWgBR/Wl47AIRZKg+YvqEObzmV\nQxBNBzAKBggqgRzPVQGDdQNJADBGAiEAnXykM0qDOWay2EMB6+c6YJ7h4n7Wbju7\nXuT5RkuM/3ICIQDAA3sLba/dQMhmKkCoJl31iZwYKz7NP+0aq6NhWDommQ==\n-----END CERTIFICATE-----";
        private const string SM2_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\nMIGTAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBHkwdwIBAQQg3WePog9R4UV/EVlk\nCw8YHu+rXC/imiB89jFmaAPeXz6gCgYIKoEcz1UBgi2hRANCAATFz9YWXNswc63k\nTWYDkfYZJRNNbcNdEQ1H49e+hF3FaFTryEzBDSdx0RELQz5Tn8/ItUlwkBMHJWMs\nSNinE3Sq\n-----END PRIVATE KEY-----";

        private const string MOCK_CERT_SN = "f2122a10319b84c2adbf83330411d7b3";
        private const string MOCK_PLAIN_STR = "U0tJVC5GbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYz";

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /apply4sub/sub_merchants/{sub_mchid}/modify-settlement）")]
        public async Task TestEncryptRequestSensitiveProperty_ModifyApplyForSubMerchantSettlementRequest()
        {
            static Models.ModifyApplyForSubMerchantSettlementRequest GenerateMockRequestModel()
            {
                return new Models.ModifyApplyForSubMerchantSettlementRequest()
                {
                    AccountName = MOCK_PLAIN_STR,
                    AccountNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.ModifyApplyForSubMerchantSettlementRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.AccountName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.AccountNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.AccountName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.AccountNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteModifyApplyForSubMerchantSettlementAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteModifyApplyForSubMerchantSettlementAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /apply4subject/applyment）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateApplyForSubjectApplymentRequest()
        {
            static Models.CreateApplyForSubjectApplymentRequest GenerateMockRequestModel()
            {
                return new Models.CreateApplyForSubjectApplymentRequest()
                {
                    Contact = new Models.CreateApplyForSubjectApplymentRequest.Types.Contact()
                    {
                        ContactName = MOCK_PLAIN_STR,
                        IdNumber = MOCK_PLAIN_STR,
                        MobileNumber = MOCK_PLAIN_STR
                    },
                    Identification = new Models.CreateApplyForSubjectApplymentRequest.Types.Identification()
                    {
                        IdName = MOCK_PLAIN_STR,
                        IdNumber = MOCK_PLAIN_STR,
                        IdAddress = MOCK_PLAIN_STR
                    },
                    UBOList = new List<Models.CreateApplyForSubjectApplymentRequest.Types.UBO>()
                    {
                        new Models.CreateApplyForSubjectApplymentRequest.Types.UBO()
                        {
                            IdName = MOCK_PLAIN_STR,
                            IdNumber = MOCK_PLAIN_STR,
                            IdAddress = MOCK_PLAIN_STR
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateApplyForSubjectApplymentRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.ContactName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.MobileNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identification!.IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identification!.IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identification!.IdAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdAddress!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.ContactName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.MobileNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identification!.IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identification!.IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identification!.IdAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdAddress!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateApplyForSubjectApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateApplyForSubjectApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /applyment4sub/applyment）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateApplyForSubMerchantApplymentRequest()
        {
            static Models.CreateApplyForSubMerchantApplymentRequest GenerateMockRequestModel()
            {
                return new Models.CreateApplyForSubMerchantApplymentRequest()
                {
                    Contact = new Models.CreateApplyForSubMerchantApplymentRequest.Types.Contact()
                    {
                        ContactName = MOCK_PLAIN_STR,
                        IdNumber = MOCK_PLAIN_STR,
                        MobileNumber = MOCK_PLAIN_STR,
                        Email = MOCK_PLAIN_STR
                    },
                    Subject = new Models.CreateApplyForSubMerchantApplymentRequest.Types.Subject()
                    {
                        Identity = new Models.CreateApplyForSubMerchantApplymentRequest.Types.Subject.Types.Identity()
                        {
                            IdCard = new Models.CreateApplyForSubMerchantApplymentRequest.Types.Subject.Types.Identity.Types.IdCard()
                            {
                                IdCardName = MOCK_PLAIN_STR,
                                IdCardNumber = MOCK_PLAIN_STR,
                                IdCardAddress = MOCK_PLAIN_STR
                            },
                            IdDocument = new Models.CreateApplyForSubMerchantApplymentRequest.Types.Subject.Types.Identity.Types.IdDocument()
                            {
                                IdDocumentName = MOCK_PLAIN_STR,
                                IdDocumentNumber = MOCK_PLAIN_STR,
                                IdDocumentAddress = MOCK_PLAIN_STR
                            }
                        },
                        UBOList = new List<Models.CreateApplyForSubMerchantApplymentRequest.Types.Subject.Types.UBO>()
                        {
                            new Models.CreateApplyForSubMerchantApplymentRequest.Types.Subject.Types.UBO()
                            {
                                IdName = MOCK_PLAIN_STR,
                                IdNumber = MOCK_PLAIN_STR,
                                IdAddress = MOCK_PLAIN_STR
                            }
                        }
                    },
                    BankAccount = new Models.CreateApplyForSubMerchantApplymentRequest.Types.BankAccount()
                    {
                        AccountName = MOCK_PLAIN_STR,
                        AccountNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateApplyForSubMerchantApplymentRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.ContactName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.MobileNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.Email!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.Identity!.IdCard!.IdCardName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.Identity!.IdCard!.IdCardNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.Identity!.IdCard!.IdCardAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.Identity!.IdDocument!.IdDocumentName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.Identity!.IdDocument!.IdDocumentNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.Identity!.IdDocument!.IdDocumentAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.UBOList![0].IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.UBOList![0].IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Subject!.UBOList![0].IdAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankAccount!.AccountName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankAccount!.AccountNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.ContactName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.MobileNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.Email!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.Identity!.IdCard!.IdCardName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.Identity!.IdCard!.IdCardNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.Identity!.IdCard!.IdCardAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.Identity!.IdDocument!.IdDocumentName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.Identity!.IdDocument!.IdDocumentNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.Identity!.IdDocument!.IdDocumentAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.UBOList![0].IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.UBOList![0].IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Subject!.UBOList![0].IdAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankAccount!.AccountName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankAccount!.AccountNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateApplyForSubMerchantApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateApplyForSubMerchantApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /brand/profitsharing/orders）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateBrandProfitSharingOrderRequest()
        {
            static Models.CreateBrandProfitSharingOrderRequest GenerateMockRequestModel()
            {
                return new Models.CreateBrandProfitSharingOrderRequest()
                {
                    ReceiverList = new List<Models.CreateBrandProfitSharingOrderRequest.Types.Receiver>()
                    {
                        new Models.CreateBrandProfitSharingOrderRequest.Types.Receiver()
                        {
                            Name = MOCK_PLAIN_STR
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateBrandProfitSharingOrderRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.ReceiverList![0].Name!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.ReceiverList![0].Name!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateBrandProfitSharingOrderAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateBrandProfitSharingOrderAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[GET] /capital/capitallhh/banks/search-banks-by-bank-account）")]
        public async Task TestEncryptRequestSensitiveProperty_QueryCapitalBanksByBankAccountRequest()
        {
            static Models.QueryCapitalBanksByBankAccountRequest GenerateMockRequestModel()
            {
                return new Models.QueryCapitalBanksByBankAccountRequest()
                {
                    AccountNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.QueryCapitalBanksByBankAccountRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.AccountNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.AccountNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteQueryCapitalBanksByBankAccountAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteQueryCapitalBanksByBankAccountAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /ecommerce/applyments）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateEcommerceApplymentRequest()
        {
            static Models.CreateEcommerceApplymentRequest GenerateMockRequestModel()
            {
                return new Models.CreateEcommerceApplymentRequest()
                {
                    Contact = new Models.CreateEcommerceApplymentRequest.Types.Contact()
                    {
                        ContactName = MOCK_PLAIN_STR,
                        IdNumber = MOCK_PLAIN_STR,
                        MobileNumber = MOCK_PLAIN_STR,
                        Email = MOCK_PLAIN_STR
                    },
                    IdCard = new Models.CreateEcommerceApplymentRequest.Types.IdCard()
                    {
                        IdCardName = MOCK_PLAIN_STR,
                        IdCardNumber = MOCK_PLAIN_STR,
                        IdCardAddress = MOCK_PLAIN_STR
                    },
                    IdDocument = new Models.CreateEcommerceApplymentRequest.Types.IdDocument()
                    {
                        IdDocumentName = MOCK_PLAIN_STR,
                        IdDocumentNumber = MOCK_PLAIN_STR,
                        IdDocumentAddress = MOCK_PLAIN_STR
                    },
                    UBOList = new List<Models.CreateEcommerceApplymentRequest.Types.UBO>()
                    {
                        new Models.CreateEcommerceApplymentRequest.Types.UBO()
                        {
                            IdName = MOCK_PLAIN_STR,
                            IdNumber = MOCK_PLAIN_STR,
                            IdAddress = MOCK_PLAIN_STR
                        }
                    },
                    BankAccount = new Models.CreateEcommerceApplymentRequest.Types.BankAccount()
                    {
                        AccountName = MOCK_PLAIN_STR,
                        AccountNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateEcommerceApplymentRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.ContactName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.MobileNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Contact!.Email!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCard!.IdCardName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCard!.IdCardNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCard!.IdCardAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdDocument!.IdDocumentName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdDocument!.IdDocumentNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdDocument!.IdDocumentAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankAccount!.AccountName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankAccount!.AccountNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.ContactName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.MobileNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Contact!.Email!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCard!.IdCardName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCard!.IdCardNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCard!.IdCardAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdDocument!.IdDocumentName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdDocument!.IdDocumentNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdDocument!.IdDocumentAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankAccount!.AccountName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankAccount!.AccountNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /ecommerce/mch-transfer/transfer-bills）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateEcommerceMerchantTransferBillRequest()
        {
            static Models.CreateEcommerceMerchantTransferBillRequest GenerateMockRequestModel()
            {
                return new Models.CreateEcommerceMerchantTransferBillRequest()
                {
                    UserName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreateEcommerceMerchantTransferBillRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceMerchantTransferBillAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceMerchantTransferBillAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /ecommerce/profitsharing/orders）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateEcommerceProfitSharingOrderRequest()
        {
            static Models.CreateEcommerceProfitSharingOrderRequest GenerateMockRequestModel()
            {
                return new Models.CreateEcommerceProfitSharingOrderRequest()
                {
                    ReceiverList = new List<Models.CreateEcommerceProfitSharingOrderRequest.Types.Receiver>()
                    {
                        new Models.CreateEcommerceProfitSharingOrderRequest.Types.Receiver()
                        {
                            Name = MOCK_PLAIN_STR
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateEcommerceProfitSharingOrderRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.ReceiverList![0].Name!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.ReceiverList![0].Name!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceProfitSharingOrderAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceProfitSharingOrderAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /ecommerce/profitsharing/receivers/add）")]
        public async Task TestEncryptRequestSensitiveProperty_AddEcommerceProfitSharingReceiverRequest()
        {
            static Models.AddEcommerceProfitSharingReceiverRequest GenerateMockRequestModel()
            {
                return new Models.AddEcommerceProfitSharingReceiverRequest()
                {
                    UserName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.AddEcommerceProfitSharingReceiverRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteAddEcommerceProfitSharingReceiverAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteAddEcommerceProfitSharingReceiverAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /ecommerce/refunds/{refund_id}/apply-abnormal-refund）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateEcommerceAbnormalRefundApplyRequest()
        {
            static Models.CreateEcommerceAbnormalRefundApplyRequest GenerateMockRequestModel()
            {
                return new Models.CreateEcommerceAbnormalRefundApplyRequest()
                {
                    BankAccountNumber = MOCK_PLAIN_STR,
                    RealName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreateEcommerceAbnormalRefundApplyRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankAccountNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealName!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankAccountNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealName!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceAbnormalRefundApplyAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateEcommerceAbnormalRefundApplyAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /eduschoolpay/contracts/presign）")]
        public async Task TestEncryptRequestSensitiveProperty_PresignEducationSchoolPayContractRequest()
        {
            static Models.PresignEducationSchoolPayContractRequest GenerateMockRequestModel()
            {
                return new Models.PresignEducationSchoolPayContractRequest()
                {
                    Identity = new Models.PresignEducationSchoolPayContractRequest.Types.Identity()
                    {
                        RealName = MOCK_PLAIN_STR,
                        CredentialNumber = MOCK_PLAIN_STR
                    },
                    BankCard = new Models.PresignEducationSchoolPayContractRequest.Types.BankCard()
                    {
                        BankCardNumber = MOCK_PLAIN_STR,
                        MobileNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.PresignEducationSchoolPayContractRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identity!.RealName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identity!.CredentialNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankCard!.BankCardNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankCard!.MobileNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identity!.RealName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identity!.CredentialNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankCard!.BankCardNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankCard!.MobileNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignEducationSchoolPayContractAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignEducationSchoolPayContractAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /fund-app/mch-transfer/transfer-bills）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateFundAppMerchantTransferBillRequest()
        {
            static Models.CreateFundAppMerchantTransferBillRequest GenerateMockRequestModel()
            {
                return new Models.CreateFundAppMerchantTransferBillRequest()
                {
                    UserName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreateFundAppMerchantTransferBillRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateFundAppMerchantTransferBillAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateFundAppMerchantTransferBillAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /marketing/membercard-open/cards/{card_id}/phone-membercard/import）")]
        public async Task TestEncryptRequestSensitiveProperty_ImportMarketingMemberCardOpenCardPhoneRequest()
        {
            static Models.ImportMarketingMemberCardOpenCardPhoneRequest GenerateMockRequestModel()
            {
                return new Models.ImportMarketingMemberCardOpenCardPhoneRequest()
                {
                    MobileNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.ImportMarketingMemberCardOpenCardPhoneRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.MobileNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.MobileNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteImportMarketingMemberCardOpenCardPhoneAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteImportMarketingMemberCardOpenCardPhoneAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /marketing/shopping-receipt/shoppingreceipts）")]
        public async Task TestEncryptRequestSensitiveProperty_UploadMarketingShoppingReceiptRequest()
        {
            static Models.UploadMarketingShoppingReceiptRequest GenerateMockRequestModel()
            {
                return new Models.UploadMarketingShoppingReceiptRequest()
                {
                    MerchantContactInformation = new Models.UploadMarketingShoppingReceiptRequest.Types.MerchantContactInformation()
                    {
                        ConsultationPhoneNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.UploadMarketingShoppingReceiptRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.MerchantContactInformation!.ConsultationPhoneNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.MerchantContactInformation!.ConsultationPhoneNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteUploadMarketingShoppingReceiptAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }


            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteUploadMarketingShoppingReceiptAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /mch_operate/risk/withdrawl-apply）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateMerchantOperateRiskWithdrawlApplyRequest()
        {
            static Models.CreateMerchantOperateRiskWithdrawlApplyRequest GenerateMockRequestModel()
            {
                return new Models.CreateMerchantOperateRiskWithdrawlApplyRequest()
                {
                    PayeeInfo = new Models.CreateMerchantOperateRiskWithdrawlApplyRequest.Types.PayeeInfo()
                    {
                        BankAccount = new Models.CreateMerchantOperateRiskWithdrawlApplyRequest.Types.PayeeInfo.Types.BankAccount()
                        {
                            AccountName = MOCK_PLAIN_STR,
                            AccountNumber = MOCK_PLAIN_STR
                        },
                        Identity = new Models.CreateMerchantOperateRiskWithdrawlApplyRequest.Types.PayeeInfo.Types.Identity()
                        {
                            IdName = MOCK_PLAIN_STR,
                            IdNumber = MOCK_PLAIN_STR,
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateMerchantOperateRiskWithdrawlApplyRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.PayeeInfo!.BankAccount!.AccountName);
                Assert.NotEqual(MOCK_PLAIN_STR, request.PayeeInfo!.BankAccount!.AccountNumber);
                Assert.NotEqual(MOCK_PLAIN_STR, request.PayeeInfo!.Identity!.IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.PayeeInfo!.Identity!.IdNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.PayeeInfo!.BankAccount!.AccountName));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.PayeeInfo!.BankAccount!.AccountNumber));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.PayeeInfo!.Identity!.IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.PayeeInfo!.Identity!.IdNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateMerchantOperateRiskWithdrawlApplyAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateMerchantOperateRiskWithdrawlApplyAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /mchalterapply/mchsubjectalterapplyment）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest()
        {
            static Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest GenerateMockRequestModel()
            {
                return new Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest()
                {
                    LegalPerson = new Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest.Types.LegalPerson()
                    {
                        IdName = MOCK_PLAIN_STR,
                        IdNumber = MOCK_PLAIN_STR,
                        IdAddress = MOCK_PLAIN_STR
                    },
                    UBOList = new List<Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest.Types.UBO>()
                    {
                        new Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest.Types.UBO()
                        {
                            IdName = MOCK_PLAIN_STR,
                            IdNumber = MOCK_PLAIN_STR,
                            IdAddress = MOCK_PLAIN_STR
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.LegalPerson!.IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.LegalPerson!.IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.LegalPerson!.IdAddress!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UBOList![0].IdAddress!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.LegalPerson!.IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.LegalPerson!.IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.LegalPerson!.IdAddress!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UBOList![0].IdAddress!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateMerchantAlterApplyMerchantSubjectAlterApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateMerchantAlterApplyMerchantSubjectAlterApplymentAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /merchant-risk-manage/report-trade-union-information）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateMerchantRiskManageTradeUnionInformationReportRequest()
        {
            static Models.CreateMerchantRiskManageTradeUnionInformationReportRequest GenerateMockRequestModel()
            {
                return new Models.CreateMerchantRiskManageTradeUnionInformationReportRequest()
                {
                    PhoneNumber = MOCK_PLAIN_STR,
                    IdCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreateMerchantRiskManageTradeUnionInformationReportRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.PhoneNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.PhoneNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateMerchantRiskManageTradeUnionInformationReportAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateMerchantRiskManageTradeUnionInformationReportAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /multiuse/users/{openid}/coupons）")]
        public async Task TestEncryptRequestSensitiveProperty_SendMultiuseUserCouponRequest()
        {
            static Models.SendMultiuseUserCouponRequest GenerateMockRequestModel()
            {
                return new Models.SendMultiuseUserCouponRequest()
                {
                    UserName = MOCK_PLAIN_STR,
                    IdCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.SendMultiuseUserCouponRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteSendMultiuseUserCouponAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteSendMultiuseUserCouponAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /new-tax-control-fapiao/fapiao-applications）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateNewTaxControlFapiaoApplicationRequest()
        {
            static Models.CreateNewTaxControlFapiaoApplicationRequest GenerateMockRequestModel()
            {
                return new Models.CreateNewTaxControlFapiaoApplicationRequest()
                {
                    Buyer = new Models.CreateNewTaxControlFapiaoApplicationRequest.Types.Buyer()
                    {
                        UserMobileNumber = MOCK_PLAIN_STR,
                        UserEmail = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateNewTaxControlFapiaoApplicationRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Buyer!.UserMobileNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Buyer!.UserEmail!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Buyer!.UserMobileNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Buyer!.UserEmail!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateNewTaxControlFapiaoApplicationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateNewTaxControlFapiaoApplicationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/insert-cards）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateNewTaxControlFapiaoApplicationCardRequest()
        {
            static Models.CreateNewTaxControlFapiaoApplicationCardRequest GenerateMockRequestModel()
            {
                return new Models.CreateNewTaxControlFapiaoApplicationCardRequest()
                {
                    Buyer = new Models.CreateNewTaxControlFapiaoApplicationCardRequest.Types.Buyer()
                    {
                        UserMobileNumber = MOCK_PLAIN_STR,
                        UserEmail = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateNewTaxControlFapiaoApplicationCardRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Buyer!.UserMobileNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Buyer!.UserEmail!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Buyer!.UserMobileNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Buyer!.UserEmail!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateNewTaxControlFapiaoApplicationCardAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateNewTaxControlFapiaoApplicationCardAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /papay/insurance-sign/contracts/pre-entrust-sign/h5）")]
        public async Task TestEncryptRequestSensitiveProperty_PresignPAPayInsuranceSignContractEntrustH5Request()
        {
            static Models.PresignPAPayInsuranceSignContractEntrustH5Request GenerateMockRequestModel()
            {
                return new Models.PresignPAPayInsuranceSignContractEntrustH5Request()
                {
                    RealIdentity = new Models.PresignPAPayInsuranceSignContractEntrustH5Request.Types.RealIdentity()
                    {
                        RealName = MOCK_PLAIN_STR,
                        IdCardNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.PresignPAPayInsuranceSignContractEntrustH5Request request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealIdentity!.RealName);
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealIdentity!.IdCardNumber);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealIdentity!.RealName));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealIdentity!.IdCardNumber));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignPAPayInsuranceSignContractEntrustH5Async(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignPAPayInsuranceSignContractEntrustH5Async(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /papay/insurance-sign/contracts/pre-entrust-sign/jsapi）")]
        public async Task TestEncryptRequestSensitiveProperty_PresignPAPayInsuranceSignContractEntrustJsapiRequest()
        {
            static Models.PresignPAPayInsuranceSignContractEntrustJsapiRequest GenerateMockRequestModel()
            {
                return new Models.PresignPAPayInsuranceSignContractEntrustJsapiRequest()
                {
                    RealIdentity = new Models.PresignPAPayInsuranceSignContractEntrustJsapiRequest.Types.RealIdentity()
                    {
                        RealName = MOCK_PLAIN_STR,
                        IdCardNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.PresignPAPayInsuranceSignContractEntrustJsapiRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealIdentity!.RealName);
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealIdentity!.IdCardNumber);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealIdentity!.RealName));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealIdentity!.IdCardNumber));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignPAPayInsuranceSignContractEntrustJsapiAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignPAPayInsuranceSignContractEntrustJsapiAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /papay/insurance-sign/contracts/pre-entrust-sign/mini-program）")]
        public async Task TestEncryptRequestSensitiveProperty_PresignPAPayInsuranceSignContractEntrustMiniProgramRequest()
        {
            static Models.PresignPAPayInsuranceSignContractEntrustMiniProgramRequest GenerateMockRequestModel()
            {
                return new Models.PresignPAPayInsuranceSignContractEntrustMiniProgramRequest()
                {
                    RealIdentity = new Models.PresignPAPayInsuranceSignContractEntrustMiniProgramRequest.Types.RealIdentity()
                    {
                        RealName = MOCK_PLAIN_STR,
                        IdCardNumber = MOCK_PLAIN_STR
                    }
                };
            }

            static void AssertMockRequestModel(Models.PresignPAPayInsuranceSignContractEntrustMiniProgramRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealIdentity!.RealName);
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealIdentity!.IdCardNumber);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealIdentity!.RealName));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealIdentity!.IdCardNumber));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignPAPayInsuranceSignContractEntrustMiniProgramAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePresignPAPayInsuranceSignContractEntrustMiniProgramAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /payroll-card/authentications/pre-order-with-auth）")]
        public async Task TestEncryptRequestSensitiveProperty_PreorderPayrollCardAuthenticationRequest()
        {
            static Models.PreorderPayrollCardAuthenticationRequest GenerateMockRequestModel()
            {
                return new Models.PreorderPayrollCardAuthenticationRequest()
                {
                    UserName = MOCK_PLAIN_STR,
                    IdCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.PreorderPayrollCardAuthenticationRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePreorderPayrollCardAuthenticationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePreorderPayrollCardAuthenticationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /payroll-card/tokens）")]
        public async Task TestEncryptRequestSensitiveProperty_CreatePayrollCardTokenRequest()
        {
            static Models.CreatePayrollCardTokenRequest GenerateMockRequestModel()
            {
                return new Models.CreatePayrollCardTokenRequest()
                {
                    UserName = MOCK_PLAIN_STR,
                    IdCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreatePayrollCardTokenRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreatePayrollCardTokenAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreatePayrollCardTokenAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /payroll-card/wesure/token-validations）")]
        public async Task TestEncryptRequestSensitiveProperty_GetPayrollCardWesureTokenValidationRequest()
        {
            static Models.GetPayrollCardWesureTokenValidationRequest GenerateMockRequestModel()
            {
                return new Models.GetPayrollCardWesureTokenValidationRequest()
                {
                    UserName = MOCK_PLAIN_STR,
                    IdCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.GetPayrollCardWesureTokenValidationRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.IdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.IdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteGetPayrollCardWesureTokenValidationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteGetPayrollCardWesureTokenValidationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /platsolution/mch-transfer/reservation/apply）")]
        public async Task TestEncryptRequestSensitiveProperty_ApplyPlatformSolutionMerchantTransferReservationRequest()
        {
            static Models.ApplyPlatformSolutionMerchantTransferReservationRequest GenerateMockRequestModel()
            {
                return new Models.ApplyPlatformSolutionMerchantTransferReservationRequest()
                {
                    UserName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.ApplyPlatformSolutionMerchantTransferReservationRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteApplyPlatformSolutionMerchantTransferReservationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteApplyPlatformSolutionMerchantTransferReservationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /profitsharing/orders）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateProfitSharingOrderRequest()
        {
            static Models.CreateProfitSharingOrderRequest GenerateMockRequestModel()
            {
                return new Models.CreateProfitSharingOrderRequest()
                {
                    ReceiverList = new List<Models.CreateProfitSharingOrderRequest.Types.Receiver>()
                    {
                        new Models.CreateProfitSharingOrderRequest.Types.Receiver()
                        {
                            Name = MOCK_PLAIN_STR
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateProfitSharingOrderRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.ReceiverList![0].Name!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.ReceiverList![0].Name!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateProfitSharingOrderAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var reqB2 = GenerateMockRequestModel();
                    await client.ExecuteCreateProfitSharingOrderAsync(reqB2);
                    AssertMockRequestModel(reqB2, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /profitsharing/receivers/add）")]
        public async Task TestEncryptRequestSensitiveProperty_AddProfitSharingReceiverRequest()
        {
            static Models.AddProfitSharingReceiverRequest GenerateMockRequestModel()
            {
                return new Models.AddProfitSharingReceiverRequest()
                {
                    Name = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.AddProfitSharingReceiverRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Name!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Name!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteAddProfitSharingReceiverAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteAddProfitSharingReceiverAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /realname/verify）")]
        public async Task TestEncryptRequestSensitiveProperty_GetRealNameVerificationRequest()
        {
            static Models.GetRealNameVerificationRequest GenerateMockRequestModel()
            {
                return new Models.GetRealNameVerificationRequest()
                {
                    CredentialId = MOCK_PLAIN_STR,
                    CredentialName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.GetRealNameVerificationRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.CredentialId);
                Assert.NotEqual(MOCK_PLAIN_STR, request.CredentialName);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.CredentialId));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.CredentialName));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteGetRealNameVerificationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteGetRealNameVerificationAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /refund/domestic/refunds/{refund_id}/apply-abnormal-refund）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateRefundDomesticAbnormalRefundApply()
        {
            static Models.CreateRefundDomesticAbnormalRefundApplyRequest GenerateMockRequestModel()
            {
                return new Models.CreateRefundDomesticAbnormalRefundApplyRequest()
                {
                    BankAccountNumber = MOCK_PLAIN_STR,
                    RealName = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreateRefundDomesticAbnormalRefundApplyRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankAccountNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.RealName!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankAccountNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.RealName!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var reqA1 = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(reqA1);
                    AssertMockRequestModel(reqA1, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var reqB1 = GenerateMockRequestModel();
                    await client.ExecuteCreateRefundDomesticAbnormalRefundApplyAsync(reqB1);
                    AssertMockRequestModel(reqB1, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var reqA2 = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(reqA2);
                    AssertMockRequestModel(reqA2, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var reqB2 = GenerateMockRequestModel();
                    await client.ExecuteCreateRefundDomesticAbnormalRefundApplyAsync(reqB2);
                    AssertMockRequestModel(reqB2, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /smartguide/guides）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateSmartGuideRequest()
        {
            static Models.CreateSmartGuideRequest GenerateMockRequestModel()
            {
                return new Models.CreateSmartGuideRequest()
                {
                    UserName = MOCK_PLAIN_STR,
                    UserMobile = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.CreateSmartGuideRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserMobile!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserMobile!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var reqA1 = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(reqA1);
                    AssertMockRequestModel(reqA1, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var reqB1 = GenerateMockRequestModel();
                    await client.ExecuteCreateSmartGuideAsync(reqB1);
                    AssertMockRequestModel(reqB1, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var reqA2 = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(reqA2);
                    AssertMockRequestModel(reqA2, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var reqB2 = GenerateMockRequestModel();
                    await client.ExecuteCreateSmartGuideAsync(reqB2);
                    AssertMockRequestModel(reqB2, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[GET] /smartguide/guides）")]
        public async Task TestEncryptRequestSensitiveProperty_QuerySmartGuidesRequest()
        {
            static Models.QuerySmartGuidesRequest GenerateMockRequestModel()
            {
                return new Models.QuerySmartGuidesRequest()
                {
                    UserMobile = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.QuerySmartGuidesRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserMobile!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserMobile!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteQuerySmartGuidesAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteQuerySmartGuidesAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[PATCH] /smartguide/guides/{guide_id}）")]
        public async Task TestEncryptRequestSensitiveProperty_UpdateSmartGuideRequest()
        {
            static Models.UpdateSmartGuideRequest GenerateMockRequestModel()
            {
                return new Models.UpdateSmartGuideRequest()
                {
                    UserName = MOCK_PLAIN_STR,
                    UserMobile = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.UpdateSmartGuideRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.UserMobile!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.UserMobile!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteUpdateSmartGuideAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteUpdateSmartGuideAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /taxi-invoice/driver/update-driver）")]
        public async Task TestEncryptRequestSensitiveProperty_UpdateTaxiInvoiceDriverRequest()
        {
            static Models.UpdateTaxiInvoiceDriverRequest GenerateMockRequestModel()
            {
                return new Models.UpdateTaxiInvoiceDriverRequest()
                {
                    DriverName = MOCK_PLAIN_STR,
                    DriverIdCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.UpdateTaxiInvoiceDriverRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.DriverName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.DriverIdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.DriverName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.DriverIdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteUpdateTaxiInvoiceDriverAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteUpdateTaxiInvoiceDriverAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /transfer/batches）")]
        public async Task TestEncryptRequestSensitiveProperty_CreateTransferBatchRequest()
        {
            static Models.CreateTransferBatchRequest GenerateMockRequestModel()
            {
                return new Models.CreateTransferBatchRequest()
                {
                    TransferDetailList = new List<Models.CreateTransferBatchRequest.Types.TransferDetail>()
                    {
                        new Models.CreateTransferBatchRequest.Types.TransferDetail()
                        {
                            UserName = MOCK_PLAIN_STR,
                            UserIdCardNumber = MOCK_PLAIN_STR
                        }
                    }
                };
            }

            static void AssertMockRequestModel(Models.CreateTransferBatchRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.TransferDetailList![0].UserName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.TransferDetailList![0].UserIdCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.TransferDetailList![0].UserName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.TransferDetailList![0].UserIdCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateTransferBatchAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecuteCreateTransferBatchAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /vehicle/etc/preopen）")]
        public async Task TestEncryptRequestSensitiveProperty_PreopenVehicleETCRequest()
        {
            static Models.PreopenVehicleETCRequest GenerateMockRequestModel()
            {
                return new Models.PreopenVehicleETCRequest()
                {
                    Identify = new Models.PreopenVehicleETCRequest.Types.Identify()
                    {
                        RealName = MOCK_PLAIN_STR,
                        CredentialNumber = MOCK_PLAIN_STR
                    },
                    BankCardNumber = MOCK_PLAIN_STR
                };
            }

            static void AssertMockRequestModel(Models.PreopenVehicleETCRequest request, Func<string, string> decryptor)
            {
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identify!.RealName!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.Identify!.CredentialNumber!);
                Assert.NotEqual(MOCK_PLAIN_STR, request.BankCardNumber!);
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identify!.RealName!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.Identify!.CredentialNumber!));
                Assert.Equal(MOCK_PLAIN_STR, decryptor.Invoke(request.BankCardNumber!));
                Assert.Equal(MOCK_CERT_SN, request.WechatpaySerialNumber!, ignoreCase: true);
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantRSACertificatePrivateKey))
            {
                using (var client = CreateMockClientUseRSA(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseRSA(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePreopenVehicleETCAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }

            if (!string.IsNullOrEmpty(TestConfigs.WechatMerchantSM2CertificatePrivateKey))
            {
                using (var client = CreateMockClientUseSM2(autoEncrypt: false))
                {
                    var request = GenerateMockRequestModel();
                    client.EncryptRequestSensitiveProperty(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }

                using (var client = CreateMockClientUseSM2(autoEncrypt: true))
                {
                    var request = GenerateMockRequestModel();
                    await client.ExecutePreopenVehicleETCAsync(request);
                    AssertMockRequestModel(request, (cipher) => Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipher)!);
                }
            }
        }
    }

    partial class TestCase_RequestEncryptionTests
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

        private static WechatTenpayClient CreateMockClientUseRSA(bool autoEncrypt)
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

            var client = new WechatTenpayClient(new WechatTenpayClientOptions()
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

        private static WechatTenpayClient CreateMockClientUseSM2(bool autoEncrypt)
        {
            var manager = new Settings.InMemoryCertificateManager();
            manager.AddEntry(new Settings.CertificateEntry(
                algorithmType: Settings.CertificateEntry.ALGORITHM_TYPE_SM2,
                serialNumber: "OBSOLETED1",
                certificate: "-----BEGIN CERTIFICATE----------END CERTIFICATE-----",
                effectiveTime: DateTimeOffset.Now.AddSeconds(-1),
                expireTime: DateTimeOffset.Now.AddSeconds(-1)
            ));
            manager.AddEntry(new Settings.CertificateEntry(
                algorithmType: Settings.CertificateEntry.ALGORITHM_TYPE_SM2,
                serialNumber: MOCK_CERT_SN,
                certificate: SM2_PEM_CERTIFICATE,
                effectiveTime: DateTimeOffset.MinValue, // 为便于测试，直接使用最小值、而非实际证书的生效时间
                expireTime: DateTimeOffset.MaxValue     // 为便于测试，直接使用最大值、而非实际证书的过期时间
            ));
            manager.AddEntry(new Settings.CertificateEntry(
                algorithmType: Settings.CertificateEntry.ALGORITHM_TYPE_SM2,
                serialNumber: "OBSOLETED2",
                certificate: "-----BEGIN CERTIFICATE----------END CERTIFICATE-----",
                effectiveTime: DateTimeOffset.Now.AddSeconds(-1),
                expireTime: DateTimeOffset.Now.AddSeconds(-1)
            ));

            var client = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = DateTimeOffset.Now.ToUnixTimeSeconds().ToString(),
                MerchantCertificateSerialNumber = Guid.NewGuid().ToString("N"),
                MerchantCertificatePrivateKey = SM2_PEM_PRIVATE_KEY,
                MerchantV3Secret = Guid.NewGuid().ToString("N"),
                SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3,
                PlatformCertificateManager = manager,
                AutoEncryptRequestSensitiveProperty = autoEncrypt
            }, new MockHttpClient());
            return client;
        }
    }
}
