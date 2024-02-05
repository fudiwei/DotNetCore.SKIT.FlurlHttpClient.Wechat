using System;
using System.Text;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsSM2UtilityTests
    {
        // 此处测试的 SM2 证书/公钥/私钥是自签名生成的，仅供执行 SM2 相关的单元测试，不能用于调用微信支付 API。
        private const string SM2_CERT_SN = "e5a81b02429d8d08";
        private const string SM2_CERT_START_DATE = "2022-11-09 21:12:20";
        private const string SM2_CERT_END_DATE = "2023-11-09 21:12:20";
        private const string SM2_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIICNzCCAdygAwIBAgIJAOWoGwJCnY0IMAoGCCqBHM9VAYN1MGcxCzAJBgNVBAYT\nAkNOMRAwDgYDVQQIDAdCZWlqaW5nMRAwDgYDVQQHDAdIYWlEaWFuMRMwEQYDVQQK\nDApHTUNlcnQub3JnMR8wHQYDVQQDDBZHTUNlcnQgR00gUm9vdCBDQSAtIDAxMB4X\nDTIyMTEwOTEzMTIyMFoXDTIzMTEwOTEzMTIyMFowSzEtMCsGA1UEAwwkU0tJVC5G\nbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYzMQ0wCwYDVQQKDARTS0lUMQsw\nCQYDVQQGEwJDTjBZMBMGByqGSM49AgEGCCqBHM9VAYItA0IABMXP1hZc2zBzreRN\nZgOR9hklE01tw10RDUfj176EXcVoVOvITMENJ3HREQtDPlOfz8i1SXCQEwclYyxI\n2KcTdKqjgYwwgYkwDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA/gwLAYJYIZIAYb4\nQgENBB8WHUdNQ2VydC5vcmcgU2lnbmVkIENlcnRpZmljYXRlMB0GA1UdDgQWBBRj\nIhoxmSgP84XT/scjkQNSWylMFTAfBgNVHSMEGDAWgBR/Wl47AIRZKg+YvqEObzmV\nQxBNBzAKBggqgRzPVQGDdQNJADBGAiEAnXykM0qDOWay2EMB6+c6YJ7h4n7Wbju7\nXuT5RkuM/3ICIQDAA3sLba/dQMhmKkCoJl31iZwYKz7NP+0aq6NhWDommQ==\n-----END CERTIFICATE-----";
        private const string SM2_PEM_PUBLIC_KEY = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAExc/WFlzbMHOt5E1mA5H2GSUTTW3D\nXRENR+PXvoRdxWhU68hMwQ0ncdERC0M+U5/PyLVJcJATByVjLEjYpxN0qg==\n-----END PUBLIC KEY-----";
        private const string SM2_PEM_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\nMIGTAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBHkwdwIBAQQg3WePog9R4UV/EVlk\nCw8YHu+rXC/imiB89jFmaAPeXz6gCgYIKoEcz1UBgi2hRANCAATFz9YWXNswc63k\nTWYDkfYZJRNNbcNdEQ1H49e+hF3FaFTryEzBDSdx0RELQz5Tn8/ItUlwkBMHJWMs\nSNinE3Sq\n-----END PRIVATE KEY-----";
        private const string SM2_HEX_EC_PRIVATE_KEY = "dd678fa20f51e1457f1159640b0f181eefab5c2fe29a207cf631666803de5f3e";
        private const string SM2_HEX_EC_PUBLIC_KEY = "04c5cfd6165cdb3073ade44d660391f61925134d6dc35d110d47e3d7be845dc56854ebc84cc10d2771d1110b433e539fcfc8b5497090130725632c48d8a71374aa";

        [Fact(DisplayName = "测试用例：从 SM2 证书中导出公钥")]
        public void TestSM2ExportPublicKeyFromCertificate()
        {
            string actualPublicKey = Utilities.SM2Utility.ExportPublicKeyFromCertificate(SM2_PEM_CERTIFICATE).Replace("\r", "").Replace("\n", "");
            string expectedPublicKey = SM2_PEM_PUBLIC_KEY.Replace("\r", "").Replace("\n", "");

            Assert.Equal(expectedPublicKey, actualPublicKey, ignoreLineEndingDifferences: true);

            string actualECHexPublicKey = Utilities.SM2Utility.ExportECPublicKeyFromCertificate(SM2_PEM_CERTIFICATE);
            string expectedECHexPublicKey = SM2_HEX_EC_PUBLIC_KEY;
            Assert.Equal(expectedECHexPublicKey, actualECHexPublicKey, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：从 SM2 证书中导出证书序列号")]
        public void TestSM2ExportSerialNumberFromCertificate()
        {
            string actualSerialNumber = Utilities.SM2Utility.ExportSerialNumberFromCertificate(SM2_PEM_CERTIFICATE);
            string expectedSerialNumber = SM2_CERT_SN;

            Assert.Equal(expectedSerialNumber, actualSerialNumber, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：从 SM2 证书中导出证书有效期的开始时间")]
        public void TestSM2ExportValidFromDateFromCertificate()
        {
            DateTimeOffset actualEffectiveTime = Utilities.SM2Utility.ExportValidFromDateFromCertificate(SM2_PEM_CERTIFICATE);
            DateTimeOffset expectedEffectiveTime = DateTimeOffset.Parse(SM2_CERT_START_DATE);

            Assert.Equal(expectedEffectiveTime, actualEffectiveTime);
        }

        [Fact(DisplayName = "测试用例：从 SM2 证书中导出证书有效期的结束时间")]
        public void TestSM2ExportValidToDateFromCertificate()
        {
            DateTimeOffset actualExpireTime = Utilities.SM2Utility.ExportValidToDateFromCertificate(SM2_PEM_CERTIFICATE);
            DateTimeOffset expectedExpireTime = DateTimeOffset.Parse(SM2_CERT_END_DATE);

            Assert.Equal(expectedExpireTime, actualExpireTime);
        }

        [Fact(DisplayName = "测试用例：从 SM2 公钥中导出 EC 公钥")]
        public void TestSM2ExportECPublicKeyFromPublicKey()
        {
            string actualECHexPublicKey = Utilities.SM2Utility.ExportECPublicKeyFromPublicKey(SM2_PEM_PUBLIC_KEY);
            string expectedSM2HexPublicKey = SM2_HEX_EC_PUBLIC_KEY;
            Assert.Equal(expectedSM2HexPublicKey, actualECHexPublicKey, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：从 SM2 私钥中导出 EC 私钥")]
        public void TestSM2ExportECPrivateKeyFromPrivateKey()
        {
            string actualSM2HexPrivateKey = Utilities.SM2Utility.ExportECPrivateKeyFromPrivateKey(SM2_PEM_PRIVATE_KEY);
            string expectedSM2HexPrivateKey = SM2_HEX_EC_PRIVATE_KEY;
            Assert.Equal(expectedSM2HexPrivateKey, actualSM2HexPrivateKey, ignoreCase: true);
        }

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
            Assert.True(Utilities.SM2Utility.VerifyWithSM3ByCertificate(SM2_PEM_CERTIFICATE, msgText, (EncodedString)signText));
            Assert.False(Utilities.SM2Utility.VerifyWithSM3ByCertificate(SM2_PEM_CERTIFICATE, msgText, (EncodedString)"FAKE SIGN"));
            Assert.True(Utilities.SM2Utility.VerifyWithSM3ByECPublicKey((EncodedString)SM2_HEX_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(msgText), Convert.FromBase64String("MEUCIQCDzgpF2Z//sbFzASVQnwme2phm4ho5cr8/1Pz0+MONTwIgeQvhoWOTk1rngYRSlHeqqwtNFVD/vf3qtgl9mecvERI=")));
            Assert.False(Utilities.SM2Utility.VerifyWithSM3ByECPublicKey((EncodedString)SM2_HEX_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(msgText), Encoding.UTF8.GetBytes("FAKE SIGN")));
        }

        [Fact(DisplayName = "测试用例：使用 SM2 公钥加密")]
        public void TestSM2Encrypt()
        {
            string plainText = "SM2EncryptTest";
            string actualCipherByPublicKey = Utilities.SM2Utility.Encrypt(SM2_PEM_PUBLIC_KEY, plainText)!;
            string actualCipherByCertificate = Utilities.SM2Utility.EncryptByCertificate(SM2_PEM_CERTIFICATE, plainText)!;
            string actualCipherByECPublicKey = Convert.ToBase64String(Utilities.SM2Utility.EncryptByECPublicKey((EncodedString)SM2_HEX_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(plainText)));

            Assert.NotNull(actualCipherByPublicKey);
            Assert.NotNull(actualCipherByCertificate);
            Assert.NotNull(actualCipherByECPublicKey);
            Assert.Equal(plainText, Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)actualCipherByPublicKey));
            Assert.Equal(plainText, Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)actualCipherByCertificate));
            Assert.Equal(plainText, Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)actualCipherByECPublicKey));
        }

        [Fact(DisplayName = "测试用例：使用 SM2 私钥解密")]
        public void TestSM2Decrypt()
        {
            string cipherText = "MHYCIGJ7gjFjd6U7kOj63HLbRgPAn6cVf4eDF4emz9oCX5gKAiBAHmgAvH2WU/2+dyqMK7/Q8eD/Q9LhYFV2gqc+fv7EiAQgiHX2wr7GCnBbAsfR3stJ1i/Csc0Mq3RzVd+ZefVlr7gEDvfJIMlMcs4Q2HoMd8Jk";
            string actualPlainByPrivateKey = Utilities.SM2Utility.Decrypt(SM2_PEM_PRIVATE_KEY, (EncodedString)cipherText)!;
            string actualPlainByECPrivateKey = Encoding.UTF8.GetString(Utilities.SM2Utility.DecryptByECPrivateKey((EncodedString)SM2_HEX_EC_PRIVATE_KEY, Convert.FromBase64String(cipherText)));
            string expectedPlain = "SM2DecryptTest";
            Assert.Equal(expectedPlain, actualPlainByPrivateKey);
            Assert.Equal(expectedPlain, actualPlainByECPrivateKey);
        }
    }
}
