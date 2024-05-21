using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsAESUtilityTests
    {
        [Fact(DisplayName = "测试用例：AES-CBC 解密")]
        public void TestAESCBCDecryption()
        {
            string iv = "KEWv/gyiIwAfHvjrLeaX6w==";
            string key = "YZJqKnNFi0KAiKUc0ggC2g==";
            string cipherText = "Gu2PVnxVWl+jK4F8c0liGxfkB5Bj3m5HRvwgEIk1Yb+36RZ3Bg7YmUnud/ooiHz0PQroipsH7GCjlGwUeT04NwmrFaP1y3dRYPLpS43ed9QZWcFIFo+8vTs3Zco6S98DUvaNEAs8duhz/BzfBOZaIHMziRqEtPFI0ZDzCgJluBirJ6Wl3UkygZ5/QLo3KA53qGdip7K48Rq8XbCwuidTCw==";

            string expectedPlainData = "{\"phoneNumber\":\"186****5613\",\"purePhoneNumber\":\"186****5613\",\"countryCode\":\"86\",\"watermark\":{\"timestamp\":1634545675,\"appid\":\"wxc****17e87e0e0a7\"}}";
            string actualPlainData = Utilities.AESUtility.DecryptWithCBC(encodingKey: new EncodedString(key, EncodingKinds.Base64), encodingIV: new EncodedString(iv, EncodingKinds.Base64), encodingCipher: new EncodedString(cipherText, EncodingKinds.Base64))!;

            Assert.Equal(expectedPlainData, actualPlainData, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：AES-GCM 加密")]
        public void TestAESGCMEncrypt()
        {
            string key = "b302fd4719dd26523d555e6fe392b91a";
            string nonce = "b302fd4719dd";
            string aad = "26523d555e6fe392b91a";
            string plainText = "Awesome SKIT.FlurlHttpClient.Wechat.Api!";

            string actualPlain = Utilities.AESUtility.EncryptWithGCM(encodingKey: new EncodedString(key, EncodingKinds.Literal), encodingNonce: new EncodedString(nonce, EncodingKinds.Literal), encodingAssociatedData: new EncodedString(aad, EncodingKinds.Literal), plainData: plainText)!;
            string expectedPlain = "bUGHWv7V1+rMtfIx4pIhD95i3J72AK+K1I0vsxBNWAUq8JLjUJ1iSY79kdqp2LCDe4IuOpPxXC0=";

            Assert.Equal(expectedPlain, actualPlain);
        }

        [Fact(DisplayName = "测试用例：AES-GCM 解密")]
        public void TestAESGCMDecrypt()
        {
            string key = "b302fd4719dd26523d555e6fe392b91a";
            string nonce = "b302fd4719dd";
            string aad = "26523d555e6fe392b91a";
            string cipherText = "bUGHWv7V1+rMtfIx4pIhD95i3J72AK+K1I0vsxBNWAUq8JLjUJ1iSY79kdqp2LCDe4IuOpPxXC0=";

            string actualPlain = Utilities.AESUtility.DecryptWithGCM(encodingKey: new EncodedString(key, EncodingKinds.Literal), encodingNonce: new EncodedString(nonce, EncodingKinds.Literal), encodingAssociatedData: new EncodedString(aad, EncodingKinds.Literal), encodingCipher: new EncodedString(cipherText, EncodingKinds.Base64))!;
            string expectedPlain = "Awesome SKIT.FlurlHttpClient.Wechat.Api!";

            Assert.Equal(expectedPlain, actualPlain);
        }
    }
}
