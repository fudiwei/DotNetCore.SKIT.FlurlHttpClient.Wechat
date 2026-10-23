namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.Utils
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_SM4UtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `SM4Utility.EncryptWithGCM`")]
        public void TestSM4EncryptWithGCM()
        {
            const string key = "b302fd4719dd2652";
            const string nonce = "b302fd4719dd";
            const string aad = "26523d555e6fe392b91a";
            const string plainText = "Awesome SKIT.FlurlHttpClient.Wechat.Api!";

            string expectedCipherText = "FqW9TkELJ5soXCSksDvqNvvBIge3rRrJAc8FP8tGaQqIHx2BljkSIfXn3miUL2FBnkpBCJ96V88=";
            string actualCipherText = Utilities.SM4Utility.EncryptWithGCM(encodingKey: new EncodedString(key, EncodingKinds.Literal), encodingNonce: new EncodedString(nonce, EncodingKinds.Literal), encodingAssociatedData: new EncodedString(aad, EncodingKinds.Literal), plainData: plainText)!;
            Assert.Equal(expectedCipherText, actualCipherText);
        }

        [Fact(DisplayName = "测试用例：SM4-GCM 解密")]
        public void TestSM4DecryptWithGCM()
        {
            const string key = "b302fd4719dd2652";
            const string nonce = "b302fd4719dd";
            const string aad = "26523d555e6fe392b91a";
            const string cipherText = "FqW9TkELJ5soXCSksDvqNvvBIge3rRrJAc8FP8tGaQqIHx2BljkSIfXn3miUL2FBnkpBCJ96V88=";

            string expectedPlainText = "Awesome SKIT.FlurlHttpClient.Wechat.Api!";
            string actualPlainText = Utilities.SM4Utility.DecryptWithGCM(encodingKey: new EncodedString(key, EncodingKinds.Literal), encodingNonce: new EncodedString(nonce, EncodingKinds.Literal), encodingAssociatedData: new EncodedString(aad, EncodingKinds.Literal), encodingCipher: new EncodedString(cipherText, EncodingKinds.Base64))!;
            Assert.Equal(expectedPlainText, actualPlainText);
        }
    }
}
