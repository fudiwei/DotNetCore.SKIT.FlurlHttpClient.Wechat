using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases.Utils
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_SM2UtilityTests
    {
        // 此处的 SM2 证书/公钥/私钥是自签名生成的，仅供执行相关单元测试，不能用于调用微信 API。
        private const string CERTIFICATE_SN = "e5a81b02429d8d08";
        private const string CERTIFICATE_NOT_BEFORE = "2022-11-09 21:12:20";
        private const string CERTIFICATE_NOT_AFTER = "2023-11-09 21:12:20";
        private const string CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIICNzCCAdygAwIBAgIJAOWoGwJCnY0IMAoGCCqBHM9VAYN1MGcxCzAJBgNVBAYT\nAkNOMRAwDgYDVQQIDAdCZWlqaW5nMRAwDgYDVQQHDAdIYWlEaWFuMRMwEQYDVQQK\nDApHTUNlcnQub3JnMR8wHQYDVQQDDBZHTUNlcnQgR00gUm9vdCBDQSAtIDAxMB4X\nDTIyMTEwOTEzMTIyMFoXDTIzMTEwOTEzMTIyMFowSzEtMCsGA1UEAwwkU0tJVC5G\nbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYzMQ0wCwYDVQQKDARTS0lUMQsw\nCQYDVQQGEwJDTjBZMBMGByqGSM49AgEGCCqBHM9VAYItA0IABMXP1hZc2zBzreRN\nZgOR9hklE01tw10RDUfj176EXcVoVOvITMENJ3HREQtDPlOfz8i1SXCQEwclYyxI\n2KcTdKqjgYwwgYkwDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA/gwLAYJYIZIAYb4\nQgENBB8WHUdNQ2VydC5vcmcgU2lnbmVkIENlcnRpZmljYXRlMB0GA1UdDgQWBBRj\nIhoxmSgP84XT/scjkQNSWylMFTAfBgNVHSMEGDAWgBR/Wl47AIRZKg+YvqEObzmV\nQxBNBzAKBggqgRzPVQGDdQNJADBGAiEAnXykM0qDOWay2EMB6+c6YJ7h4n7Wbju7\nXuT5RkuM/3ICIQDAA3sLba/dQMhmKkCoJl31iZwYKz7NP+0aq6NhWDommQ==\n-----END CERTIFICATE-----";
        private const string SM2_PUBLIC_KEY = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAExc/WFlzbMHOt5E1mA5H2GSUTTW3D\nXRENR+PXvoRdxWhU68hMwQ0ncdERC0M+U5/PyLVJcJATByVjLEjYpxN0qg==\n-----END PUBLIC KEY-----";
        private const string SM2_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----\nMIGTAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBHkwdwIBAQQg3WePog9R4UV/EVlk\nCw8YHu+rXC/imiB89jFmaAPeXz6gCgYIKoEcz1UBgi2hRANCAATFz9YWXNswc63k\nTWYDkfYZJRNNbcNdEQ1H49e+hF3FaFTryEzBDSdx0RELQz5Tn8/ItUlwkBMHJWMs\nSNinE3Sq\n-----END PRIVATE KEY-----";
        private const string SM2_EC_PUBLIC_KEY = "04c5cfd6165cdb3073ade44d660391f61925134d6dc35d110d47e3d7be845dc56854ebc84cc10d2771d1110b433e539fcfc8b5497090130725632c48d8a71374aa";
        private const string SM2_EC_PRIVATE_KEY = "dd678fa20f51e1457f1159640b0f181eefab5c2fe29a207cf631666803de5f3e";
        
        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportPublicKeyFromCertificate`")]
        public void TestSM2ExportPublicKeyFromCertificate()
        {
            string expectedPublicKey = SM2_PUBLIC_KEY.Replace("\r", "").Replace("\n", "").Trim();
            string actualPublicKey = Utilities.SM2Utility.ExportPublicKeyFromCertificate(CERTIFICATE).Replace("\r", "").Replace("\n", "").Trim();
            Assert.Equal(expectedPublicKey, actualPublicKey);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportECPublicKeyFromCertificate`")]
        public void TestSM2ExportECPublicKeyFromCertificate()
        {
            string expectedECPublicKey = SM2_EC_PUBLIC_KEY;
            string actualECPublicKey = Utilities.SM2Utility.ExportECPublicKeyFromCertificate(CERTIFICATE);
            Assert.Equal(expectedECPublicKey, actualECPublicKey, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportSerialNumberFromCertificate`")]
        public void TestSM2ExportSerialNumberFromCertificate()
        {
            string expectedSerialNumber = CERTIFICATE_SN;
            string actualSerialNumber = Utilities.SM2Utility.ExportSerialNumberFromCertificate(CERTIFICATE);
            Assert.Equal(expectedSerialNumber, actualSerialNumber, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportValidFromDateFromCertificate`")]
        public void TestSM2ExportValidFromDateFromCertificate()
        {
            DateTimeOffset expectedNotBefore = DateTimeOffset.Parse(CERTIFICATE_NOT_BEFORE);
            DateTimeOffset actualNotBefore = Utilities.SM2Utility.ExportValidFromDateFromCertificate(CERTIFICATE);
            Assert.Equal(expectedNotBefore, actualNotBefore);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportValidToDateFromCertificate`")]
        public void TestSM2ExportValidToDateFromCertificate()
        {
            DateTimeOffset expectedNotAfter = DateTimeOffset.Parse(CERTIFICATE_NOT_AFTER);
            DateTimeOffset actualNotAfter = Utilities.SM2Utility.ExportValidToDateFromCertificate(CERTIFICATE);
            Assert.Equal(expectedNotAfter, actualNotAfter);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportECPublicKeyFromPublicKey`")]
        public void TestSM2ExportECPublicKeyFromPublicKey()
        {
            string expectedECPublicKey = SM2_EC_PUBLIC_KEY;
            string actualECPublicKey = Utilities.SM2Utility.ExportECPublicKeyFromPublicKey(SM2_PUBLIC_KEY);
            Assert.Equal(expectedECPublicKey, actualECPublicKey, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.ExportECPrivateKeyFromPrivateKey`")]
        public void TestSM2ExportECPrivateKeyFromPrivateKey()
        {
            string expectedECPrivateKey = SM2_EC_PRIVATE_KEY;
            string actualECPrivateKey = Utilities.SM2Utility.ExportECPrivateKeyFromPrivateKey(SM2_PRIVATE_KEY);
            Assert.Equal(expectedECPrivateKey, actualECPrivateKey, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.SignWithSM3`")]
        public void TestSM2SignWithSM3()
        {
            const string plainText = "SM2WithSM3SignTest";

            Assert.Multiple(() =>
            {
                string signature = Utilities.SM2Utility.SignWithSM3(SM2_PRIVATE_KEY, plainText)!;
                Assert.NotNull(signature);
                Assert.True(Utilities.SM2Utility.VerifyWithSM3(SM2_PUBLIC_KEY, plainText, (EncodedString)signature));
            });

            Assert.Multiple(() =>
            {
                string signature = Convert.ToBase64String(Utilities.SM2Utility.SignWithSM3ByECPrivateKey((EncodedString)SM2_EC_PRIVATE_KEY, Encoding.UTF8.GetBytes(plainText)));
                Assert.NotNull(signature);
                Assert.True(Utilities.SM2Utility.VerifyWithSM3(SM2_PUBLIC_KEY, plainText, (EncodedString)signature));
            });
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.VerifyWithSM3`")]
        public void TestSM2VerifyWithSM3()
        {
            const string plainText = "SM2WithSM3SignTest";
            const string signature = "MEUCIQCDzgpF2Z//sbFzASVQnwme2phm4ho5cr8/1Pz0+MONTwIgeQvhoWOTk1rngYRSlHeqqwtNFVD/vf3qtgl9mecvERI=";

            Assert.Multiple(() =>
            {
                Assert.True(Utilities.SM2Utility.VerifyWithSM3(SM2_PUBLIC_KEY, plainText, (EncodedString)signature));
                Assert.False(Utilities.SM2Utility.VerifyWithSM3(SM2_PUBLIC_KEY, plainText, (EncodedString)"FAKE SIGN"));
            });

            Assert.Multiple(() =>
            {
                Assert.True(Utilities.SM2Utility.VerifyWithSM3ByCertificate(CERTIFICATE, plainText, (EncodedString)signature));
                Assert.False(Utilities.SM2Utility.VerifyWithSM3ByCertificate(CERTIFICATE, plainText, (EncodedString)"FAKE SIGN"));
            });

            Assert.Multiple(() =>
            {
                Assert.True(Utilities.SM2Utility.VerifyWithSM3ByECPublicKey((EncodedString)SM2_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(plainText), Convert.FromBase64String("MEUCIQCDzgpF2Z//sbFzASVQnwme2phm4ho5cr8/1Pz0+MONTwIgeQvhoWOTk1rngYRSlHeqqwtNFVD/vf3qtgl9mecvERI=")));
                Assert.False(Utilities.SM2Utility.VerifyWithSM3ByECPublicKey((EncodedString)SM2_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(plainText), Encoding.UTF8.GetBytes("FAKE SIGN")));
            });
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.Encrypt`")]
        public void TestSM2Encrypt()
        {
            const string plainText = "SM2EncryptTest";

            Assert.Multiple(() =>
            {
                string cipherText = Utilities.SM2Utility.Encrypt(SM2_PUBLIC_KEY, plainText)!;
                Assert.NotNull(cipherText);
                Assert.Equal(plainText, Utilities.SM2Utility.Decrypt(SM2_PRIVATE_KEY, (EncodedString)cipherText));
            });

            Assert.Multiple(() =>
            {
                string cipherText = Utilities.SM2Utility.EncryptByCertificate(CERTIFICATE, plainText)!;
                Assert.NotNull(cipherText);
                Assert.Equal(plainText, Utilities.SM2Utility.Decrypt(SM2_PRIVATE_KEY, (EncodedString)cipherText));
            });

            Assert.Multiple(() =>
            {
                string cipherText = Convert.ToBase64String(Utilities.SM2Utility.EncryptByECPublicKey((EncodedString)SM2_EC_PUBLIC_KEY, Encoding.UTF8.GetBytes(plainText)));
                Assert.NotNull(cipherText);
                Assert.Equal(plainText, Utilities.SM2Utility.Decrypt(SM2_PRIVATE_KEY, (EncodedString)cipherText));
            });
        }

        [Fact(DisplayName = "测试用例：工具类 `SM2Utility.Decrypt`")]
        public void TestSM2Decrypt()
        {
            const string cipherText = "MHYCIGJ7gjFjd6U7kOj63HLbRgPAn6cVf4eDF4emz9oCX5gKAiBAHmgAvH2WU/2+dyqMK7/Q8eD/Q9LhYFV2gqc+fv7EiAQgiHX2wr7GCnBbAsfR3stJ1i/Csc0Mq3RzVd+ZefVlr7gEDvfJIMlMcs4Q2HoMd8Jk";

            string expectedPlainText = "SM2DecryptTest";

            Assert.Multiple(() =>
            {
                string actualPlainText = Utilities.SM2Utility.Decrypt(SM2_PRIVATE_KEY, (EncodedString)cipherText)!;
                Assert.Equal(expectedPlainText, actualPlainText);
            });

            Assert.Multiple(() =>
            {
                string actualPlainText = Encoding.UTF8.GetString(Utilities.SM2Utility.DecryptByECPrivateKey((EncodedString)SM2_EC_PRIVATE_KEY, Convert.FromBase64String(cipherText)));
                Assert.Equal(expectedPlainText, actualPlainText);
            });
        }
    }
}
