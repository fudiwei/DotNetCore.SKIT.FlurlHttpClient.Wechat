using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests.TestCases.Utils
{
    using SKIT.FlurlHttpClient.Primitives;

    public partial class TestCase_RSAUtilityTests
    {
        // 此处的 RSA 证书/公钥/私钥是自签名生成的，仅供执行相关单元测试，不能用于调用微信 API。
        private const string RSA_PUBLIC_KEY_PKCS1 = "-----BEGIN RSA PUBLIC KEY-----MIIBCgKCAQEAuwQaAJGSMda9ESGhyY2PPuVds8OjoqyRi29IEQgXJ03Bu/o6KjZVbPQT4n3WncrT0c92zA6lazJDbaXQkHlvdDpOo3FqBvczDDT0jveCfg7azeOmRxHE8P/iWOkQm+Dhk5hnmfxqtX7pzu2quzuGt9JH4FxPhNEOkn4/uRn+1qo/KrrU2Db09gm3aPjOWTT5XEVD9tPNTsZr/vaKYGCQKTqeRWhDGL3JAgyyLgGyGTAOTt0gl0MPG/O6omwELTVQdzXqyRrKgx0tEhIKoeYBVPKbWOTJyXsRO9dcfXKu56jry9QyqjFHcVtfCuphOaFIhGUEDYuAIJsqBKJqrSZoVQIDAQAB-----END RSA PUBLIC KEY-----";
        private const string RSA_PRIVATE_KEY_PKCS1 = "-----BEGIN RSA PRIVATE KEY-----MIIEogIBAAKCAQEAuwQaAJGSMda9ESGhyY2PPuVds8OjoqyRi29IEQgXJ03Bu/o6KjZVbPQT4n3WncrT0c92zA6lazJDbaXQkHlvdDpOo3FqBvczDDT0jveCfg7azeOmRxHE8P/iWOkQm+Dhk5hnmfxqtX7pzu2quzuGt9JH4FxPhNEOkn4/uRn+1qo/KrrU2Db09gm3aPjOWTT5XEVD9tPNTsZr/vaKYGCQKTqeRWhDGL3JAgyyLgGyGTAOTt0gl0MPG/O6omwELTVQdzXqyRrKgx0tEhIKoeYBVPKbWOTJyXsRO9dcfXKu56jry9QyqjFHcVtfCuphOaFIhGUEDYuAIJsqBKJqrSZoVQIDAQABAoIBAFEqL4rNovBkbTvxJ8FM4b1/WFJ7dxpT4Prt+g4CP+I7+ff2WqYVXK/jonmq+akT7Shi7QEU3jAO6Xq9+y2otnlwEM8YmtaZFJuYpAckXosNMWMoCPNRP/MEax0BUccFK4GeJGCNT1aj1R+MwItwA0DmT3GNPqm6/aMQjeFs6dAJ500SUVlWfMGnO3c40XGq3bHHNfTdZsdRa5NzlCViRKtc6vgoPf4iOHGE30da771XJ06iZb/2iLYcZyWlhQMU5vBUYyVd4oykVldNuGcrLQIffJsVR7Gq/aHEujQ6WSAmd2VZwGYRLxBCXVm/LGsaiw1AffAgLEazxLMBmFfWg2ECgYEA4TC6wE1GVacft6D3UsLUcKxTLIrqAE23RI6ky5wT+3MDlMIwWRLBdJO9zTQ2MG3EgruVKXgE6GEEM4cLPmhaxg1YrpRoLBr+t78lR7WwU+i9dM8GrJwoIqnCXjF1sjKa05/iEtZHbTMaXuSirHHMjEoW40I3N6ygLd4Bewzct70CgYEA1JpR4/9TiVY9k4ml5/dvatzr+4mVplTqJ3U5Ie8lhwaAtj+ouXsERaLwpLp72gP+m1rjDHoU8zuYnfVqxm35GNf7Wv1YOlpXHcebMWLkvBc6112KmcnxmSiRAHv94AAT2YxSRPu57ITlB0biUIWiCxUlevbavLsn1vHtpx1S0HkCgYBDF8esX9miz2ZNybGmgNHWuCEX1lOdv4no7S8AUwJJGp1ohursvv/Qgew85V930lyILudkMZQUwEMGLygUcfcJpxRS/3iCG5DkohizYtikR2WbFcuBRg1XNojok4fjjdw/TRWIUzt4t48V0rz87/LnoXNsRmA5QD+BKvH5/X0NaQKBgD8oXP17Y0igSwiiUpv3oKzBVoVSGRfhj/IK298d2SsknmYFwUzgo6NARXbaQ2K/3wot1NdnCQQ9BxidyIuMLfzYZL5iFqy3G7woCQ2B0GukBwHlsv/+wvv51iGrs/6wZzUwf1wo39HIpPUldKPxHvNl482EufRpMOuk0THc/zYZAoGAROAO+sObNRQilQ4iKIO/8VQBoHnde6WF1Z7FNsQlxZxJrzZrO82OIWOPucaPNNOn0I/V4ttaFo7GSWvRX16ADvA0dNMXuB+5syGt5dgDPCOtTXzPZq0Twzwgc5uyknkS1cn9Gt+a0oZ9/+zGzjKK2tcX+HwM7r6bTaxVNzjd6Hg=-----END RSA PRIVATE KEY-----";

        [Fact(DisplayName = "测试用例：工具类 `RSAUtility.DecryptWithECB`")]
        public void TestRSADecryptWithECB()
        {
            static void AssertStubs(Func<string, EncodedString, string, EncodedString> decryptor)
            {
                const string cipherText = "ewwZ8LmXVJpkJpj/JWcz16L4bePAGcf3Fi2EKyC6AS3JsF5u4aku7iOYqtcAczjoYwE1fqSadRd6YTrWr3tLP3uWFYmhqthQoaAcjmQS0vHYRFeS1V7q5hbziVLRp7C42S4YrvqXAmSmUyjPUXG5tXFVchARVkTr1F53HGoPP+iBg+i8y0uJK4FgiuKraFgdtKofv/k5/30xKzRHxdLFCFt1rF7wL+Hk/7Bl0tFZM/rfhmuvwbf46zWhxKKviAge+61tEot4QCSBLnAFpPuSQsTOOSOrlCl92DwW54dWdlWwhqkTVHdm6pXEdUE66y1yoZkXfpqjnONjta0njqN/Jw==";

                string expectedPlainText = "RsaDecryptTest";
                string actualPlainText = decryptor.Invoke(RSA_PRIVATE_KEY_PKCS1, new EncodedString(cipherText, EncodingKinds.Base64), Utilities.RSAUtility.PADDING_MODE_PKCS1)!;
                Assert.Equal(expectedPlainText, actualPlainText);
            }

            AssertStubs(MockRSAUtility.DecryptWithECB);
            AssertStubs(Utilities.RSAUtility.DecryptWithECB);
        }
    }

    partial class TestCase_RSAUtilityTests
    {
        /// <summary>
        /// 基于 BouncyCastle.Cryptography 实现的 RSA 算法工具类。
        /// 关键方法签名与 `RSAUtility` 完全一致，作为基线检测使用。
        /// </summary>
        private static class MockRSAUtility
        {
            private static byte[] DecryptWithECB(RsaKeyParameters rsaPrivateKeyParams, byte[] cipherBytes, string paddingMode)
            {
                IBufferedCipher cipher = CipherUtilities.GetCipher($"RSA/ECB/{paddingMode}");
                cipher.Init(false, rsaPrivateKeyParams);
                return cipher.DoFinal(cipherBytes);
            }

            public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes, string paddingMode)
            {
                if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
                if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

                RsaKeyParameters rsaPrivateKeyParams = (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
                return DecryptWithECB(rsaPrivateKeyParams, cipherBytes, paddingMode);
            }

            public static EncodedString DecryptWithECB(string privateKeyPem, EncodedString encodingCipher, string paddingMode)
            {
                if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
                if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

                byte[] privateKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyBytes(privateKeyPem);
                byte[] cipherBytes = EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64);
                byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes, paddingMode);
                return EncodedString.ToLiteralString(plainBytes);
            }
        }
    }
}
