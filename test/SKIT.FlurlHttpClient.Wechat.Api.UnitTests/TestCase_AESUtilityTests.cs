using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_AESUtilityTests
    {
        [Fact(DisplayName = "测试用例：AES-CBC 解密")]
        public void TestAESCBCDecryption()
        {
            string iv = "KEWv/gyiIwAfHvjrLeaX6w==";
            string key = "YZJqKnNFi0KAiKUc0ggC2g==";
            string cipherText = "Gu2PVnxVWl+jK4F8c0liGxfkB5Bj3m5HRvwgEIk1Yb+36RZ3Bg7YmUnud/ooiHz0PQroipsH7GCjlGwUeT04NwmrFaP1y3dRYPLpS43ed9QZWcFIFo+8vTs3Zco6S98DUvaNEAs8duhz/BzfBOZaIHMziRqEtPFI0ZDzCgJluBirJ6Wl3UkygZ5/QLo3KA53qGdip7K48Rq8XbCwuidTCw==";
            
            string expectedPlainData = "{\"phoneNumber\":\"186****5613\",\"purePhoneNumber\":\"186****5613\",\"countryCode\":\"86\",\"watermark\":{\"timestamp\":1634545675,\"appid\":\"wxc****17e87e0e0a7\"}}";
            string actualPlainData = Utilities.AESUtility.DecryptWithCBC(encodingKey: key, encodingIV: iv, encodingCipherText: cipherText);
            
            Assert.Equal(expectedPlainData, actualPlainData, ignoreCase: true);
        }
    }
}
