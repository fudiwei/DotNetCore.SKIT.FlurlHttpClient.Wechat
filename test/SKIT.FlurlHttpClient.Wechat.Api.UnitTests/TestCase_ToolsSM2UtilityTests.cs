using System;
using System.Text;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsSM2UtilityTests
    {
        // 此处测试的 SM2 证书/公钥/私钥是自签名生成的，仅供执行 SM2 相关的单元测试，不能用于调用微信 API。
        private const string SM2_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIICNzCCAdygAwIBAgIJAOWoGwJCnY0IMAoGCCqBHM9VAYN1MGcxCzAJBgNVBAYT\nAkNOMRAwDgYDVQQIDAdCZWlqaW5nMRAwDgYDVQQHDAdIYWlEaWFuMRMwEQYDVQQK\nDApHTUNlcnQub3JnMR8wHQYDVQQDDBZHTUNlcnQgR00gUm9vdCBDQSAtIDAxMB4X\nDTIyMTEwOTEzMTIyMFoXDTIzMTEwOTEzMTIyMFowSzEtMCsGA1UEAwwkU0tJVC5G\nbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYzMQ0wCwYDVQQKDARTS0lUMQsw\nCQYDVQQGEwJDTjBZMBMGByqGSM49AgEGCCqBHM9VAYItA0IABMXP1hZc2zBzreRN\nZgOR9hklE01tw10RDUfj176EXcVoVOvITMENJ3HREQtDPlOfz8i1SXCQEwclYyxI\n2KcTdKqjgYwwgYkwDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA/gwLAYJYIZIAYb4\nQgENBB8WHUdNQ2VydC5vcmcgU2lnbmVkIENlcnRpZmljYXRlMB0GA1UdDgQWBBRj\nIhoxmSgP84XT/scjkQNSWylMFTAfBgNVHSMEGDAWgBR/Wl47AIRZKg+YvqEObzmV\nQxBNBzAKBggqgRzPVQGDdQNJADBGAiEAnXykM0qDOWay2EMB6+c6YJ7h4n7Wbju7\nXuT5RkuM/3ICIQDAA3sLba/dQMhmKkCoJl31iZwYKz7NP+0aq6NhWDommQ==\n-----END CERTIFICATE-----";
        private const string SM2_PEM_PUBLIC_KEY = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAExc/WFlzbMHOt5E1mA5H2GSUTTW3D\nXRENR+PXvoRdxWhU68hMwQ0ncdERC0M+U5/PyLVJcJATByVjLEjYpxN0qg==\n-----END PUBLIC KEY-----";
        private const string SM2_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\nMIGTAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBHkwdwIBAQQg3WePog9R4UV/EVlk\nCw8YHu+rXC/imiB89jFmaAPeXz6gCgYIKoEcz1UBgi2hRANCAATFz9YWXNswc63k\nTWYDkfYZJRNNbcNdEQ1H49e+hF3FaFTryEzBDSdx0RELQz5Tn8/ItUlwkBMHJWMs\nSNinE3Sq\n-----END PRIVATE KEY-----";
        private const string SM2_HEX_EC_PRIVATE_KEY = "dd678fa20f51e1457f1159640b0f181eefab5c2fe29a207cf631666803de5f3e";
        private const string SM2_HEX_EC_PUBLIC_KEY = "04c5cfd6165cdb3073ade44d660391f61925134d6dc35d110d47e3d7be845dc56854ebc84cc10d2771d1110b433e539fcfc8b5497090130725632c48d8a71374aa";

        [Fact(DisplayName = "测试用例：SM2WithSM3 签名生成")]
        public void TestSM2SignatureSM2WithSM3Sign()
        {
            string msgText = "SM2WithSM3SignTest";
            string actualSignByPrivateKey = Utilities.SM2Utility.SignWithSM3(SM2_PEM_PRIVATE_KEY, msgText)!;
            string actualSignByECPrivateKey = Convert.ToBase64String(Utilities.SM2Utility.SignWithSM3ByECPrivateKey((EncodedString)SM2_HEX_EC_PRIVATE_KEY, Encoding.UTF8.GetBytes(msgText)));

            Assert.NotNull(actualSignByPrivateKey);
            Assert.NotNull(actualSignByECPrivateKey);
            Assert.True(Utilities.SM2Utility.VerifyWithSM3(SM2_PEM_PUBLIC_KEY, msgText, (EncodedString)actualSignByPrivateKey));
        }

        [Fact(DisplayName = "测试用例：SM2WithSM3 签名验证")]
        public void TestSM2SignatureSM2WithSM3Verify()
        {
            string msgText = "SM2WithSM3SignTest";
            string signText = "MEUCIQCDzgpF2Z//sbFzASVQnwme2phm4ho5cr8/1Pz0+MONTwIgeQvhoWOTk1rngYRSlHeqqwtNFVD/vf3qtgl9mecvERI=";
            
            Assert.True(Utilities.SM2Utility.VerifyWithSM3(SM2_PEM_PUBLIC_KEY, msgText, (EncodedString)signText));
            Assert.False(Utilities.SM2Utility.VerifyWithSM3(SM2_PEM_PUBLIC_KEY, msgText, (EncodedString)"FAKE SIGN"));
            Assert.True(Utilities.SM2Utility.VerifyWithSM3ByECPublicKey((EncodedString)SM2_HEX_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(msgText), Convert.FromBase64String("MEUCIQCDzgpF2Z//sbFzASVQnwme2phm4ho5cr8/1Pz0+MONTwIgeQvhoWOTk1rngYRSlHeqqwtNFVD/vf3qtgl9mecvERI=")));
            Assert.False(Utilities.SM2Utility.VerifyWithSM3ByECPublicKey((EncodedString)SM2_HEX_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(msgText), Encoding.UTF8.GetBytes("FAKE SIGN")));
        }
    }
}
