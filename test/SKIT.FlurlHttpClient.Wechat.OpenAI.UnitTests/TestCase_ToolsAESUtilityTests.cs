using System;
using System.Text;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsAESUtilityTests
    {
        [Fact(DisplayName = "测试用例：AES-CBC 加密")]
        public void TestAESCBCEncryption()
        {
            string key = "q1Os1ZMe0nG28KUEx9lg3HjK7V5QyXvi212fzsgDqgz=";
            string iv = "q1Os1ZMe0nG28KUEx9lg3A=="; // iv 是 key 的前 16 个字节
            string plainText = "{\"answer_type\":\"text\",\"text_info\":{\"short_answer\":\"answer\"}}";

            string expectedCipherData = "aJhHfz6xc9iQiTLwusQe0HYKT6itYwq/YgQHltmLPf2UfpD+8ODJ8lrrxOMxy5NiALZqz1eYGtwD7cLQDP3ADg==";
            string actualCipherData = Utilities.AESUtility.EncryptWithCBC(encodingKey: new EncodedString(key, EncodingKinds.Base64), encodingIV: new EncodedString(iv, EncodingKinds.Base64), plainData: plainText)!;

            Assert.Equal(expectedCipherData, actualCipherData, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：AES-CBC 解密")]
        public void TestAESCBCDecryption()
        {
            string key = "q1Os1ZMe0nG28KUEx9lg3HjK7V5QyXvi212fzsgDqgz=";
            string iv = "q1Os1ZMe0nG28KUEx9lg3A=="; // iv 是 key 的前 16 个字节
            string cipherText = "rUWkvTY9vRPOeVDSH/IdNXHmvgsUQtPkp7QtBQjSS1tcuTHGPWv8O3PlxbnsjCogsM7+EY+As4yF2kp4yxXpP2U7RmbDsU/luRO/EqkpFFsoxMZZArz2XH1YeSdnDyHYPWzjiicBYjNiqqpTMX8ekrqooN0cCEH7JBcbEe6btmiK8hZkysKTUJfG1DTpbONxON5+YuVPelVpzW5ry9sRYLDcqhImMb9FqI+BlIVAIXt5g+e70rheSqpeXz98pEROx7yPeRi3tXPAibuwg+vKDhoN6LuM0hzvyNzPjwK2gMmQB5yVuBZUalYIIZTVaMNGu4H6RK6MovLyM2cKfMUTphKaBBKpAvsV0o4/QRY0MvxeRYvZAQXEzOG3dJ7BRB2KEqBKttT7jMK8MO5HEXDE0CJxtNI4Rjww9XYmPhBM7lOZSF97YNEg1NhwcXvUc3YcrR334PhWJeu2dZCHaJzBqVXFxq/WprNHM0Gw06o6p5oWb4/nzXKYbpJWDyqTN/aztwo5sppHwlYrzNzF7gERP691qoabTHiCd0H+Ea3t65gTyNo2+ssvS1RVsKubApS4BkbZb/EaZCTKP20pcvDBoJk3QLi8ObyBq8sIcLwVjzelLMUgCDa059gBuao+S9qdHXebEZyS49BqAxngMWjHU5uCRO/x2b9w8nwfCCT8b0Q=";

            string expectedPlainData = "{\"RequestId\":\"123123456456789789123456789\",\"SessionId\":\"12345678901234567_12345678909876543\",\"Query\":\"北京限行尾号是多少\",\"SkillName\":\"限行\",\"IntentName\":\"查限行尾号\",\"Slots\":[{\"SlotName\":\"from_loc\",\"SlotValue\":\"北京\",\"NormalizeValue\":\"{\\\"type\\\":\\\"LOC_CHINA_CITY\\\",\\\"city\\\":\\\"北京市\\\",\\\"city_simple\\\":\\\"北京\\\",\\\"loc_ori\\\":\\\"北京\\\"}\"}],\"Timestamp\":1704135845,\"Signature\":\"96f439043e1f7d2bb38162e35406f173\",\"ThirdApiId\":1234,\"ThirdApiName\":\"车辆限行\",\"UserId\":\"97f7e892\"}";
            string actualPlainData = Utilities.AESUtility.DecryptWithCBC(encodingKey: new EncodedString(key, EncodingKinds.Base64), encodingIV: new EncodedString(iv, EncodingKinds.Base64), encodingCipher: new EncodedString(cipherText, EncodingKinds.Base64))!;

            Assert.Equal(expectedPlainData, actualPlainData, ignoreCase: true);
        }
    }
}
