using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsSM4UtilityTests
    {
        [Fact(DisplayName = "测试用例：SM4-GCM 加密")]
        public void TestSM4GCMEncrypt()
        {
            string key = "b302fd4719dd2652";
            string nonce = "b302fd4719dd";
            string aad = "26523d555e6fe392b91a";
            string plainText = "Awesome SKIT.FlurlHttpClient.Wechat.Api!";

            string actualPlain = Utilities.SM4Utility.EncryptWithGCM(encodingKey: new EncodedString(key, EncodingKinds.Literal), encodingNonce: new EncodedString(nonce, EncodingKinds.Literal), encodingAssociatedData: new EncodedString(aad, EncodingKinds.Literal), plainData: plainText)!;
            string expectedPlain = "FqW9TkELJ5soXCSksDvqNvvBIge3rRrJAc8FP8tGaQqIHx2BljkSIfXn3miUL2FBnkpBCJ96V88=";

            Assert.Equal(expectedPlain, actualPlain);
        }

        [Fact(DisplayName = "测试用例：SM4-GCM 解密")]
        public void TestSM4GCMDecrypt()
        {
            string key = "b302fd4719dd2652";
            string nonce = "b302fd4719dd";
            string aad = "26523d555e6fe392b91a";
            string cipherText = "FqW9TkELJ5soXCSksDvqNvvBIge3rRrJAc8FP8tGaQqIHx2BljkSIfXn3miUL2FBnkpBCJ96V88=";

            string actualPlain = Utilities.SM4Utility.DecryptWithGCM(encodingKey: new EncodedString(key, EncodingKinds.Literal), encodingNonce: new EncodedString(nonce, EncodingKinds.Literal), encodingAssociatedData: new EncodedString(aad, EncodingKinds.Literal), encodingCipher: new EncodedString(cipherText, EncodingKinds.Base64))!;
            string expectedPlain = "Awesome SKIT.FlurlHttpClient.Wechat.Api!";

            Assert.Equal(expectedPlain, actualPlain);
        }
    }
}
