using System;
using System.Text;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsAESUtilityTests
    {
        [Fact(DisplayName = "测试用例：AES-ECB 解密")]
        public void TestAESGCMDecrypt()
        {
            string key = "01234567890abcdefedcba9876543210";
            string cipherText = "l/aL5GyVfl/tw3Lww6GvCQ==";

            string actualPlain = Utilities.AESUtility.DecryptWithECB(encodingKey: (EncodedString)Convert.ToBase64String(Encoding.UTF8.GetBytes(key)), encodingCipher: (EncodedString)cipherText)!;
            string expectedPlain = "SKIT is great!";

            Assert.Equal(expectedPlain, actualPlain);
        }
    }
}
