using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests.TestCases.Utils
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_AESUtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `AESUtility.DecryptWithECB`")]
        public void TestAESDecryptWithECB()
        {
            const string key = "01234567890abcdefedcba9876543210";
            const string cipherText = "l/aL5GyVfl/tw3Lww6GvCQ==";

            string actualPlainText = Utilities.AESUtility.DecryptWithECB(encodingKey: (EncodedString)Convert.ToBase64String(Encoding.UTF8.GetBytes(key)), encodingCipher: (EncodedString)cipherText)!;
            string expectedPlainText = "SKIT is great!";
            Assert.Equal(expectedPlainText, actualPlainText);
        }
    }
}
