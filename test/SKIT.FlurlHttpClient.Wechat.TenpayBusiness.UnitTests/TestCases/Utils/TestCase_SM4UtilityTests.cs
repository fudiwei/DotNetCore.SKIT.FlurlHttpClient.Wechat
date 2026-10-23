namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests.TestCases.Utils
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_SM4UtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `SM4Utility.EncryptWithCBC`")]
        public void TestSM4Encrypt()
        {
            const string key = "MDAwMDAwMDAwMDAwMDAwMA==";
            const string iv = "OGE2YzRkZGQ4YTZjNGRkZA==";
            const string plainText = "Awesome SKIT.FlurlHttpClient.Wechat.TenpayBusiness!";

            string actualCipherText = Utilities.SM4Utility.EncryptWithCBC(encodingKey: (EncodedString)key, encodingIV: (EncodedString)iv, plainData: plainText)!;
            string expectedCipherText = "Fm3z4Ipjuaj4oQLfxpTrvoZm5JdbjvjrJo3PRhvSsOppk8/PN+izH3Wo9Rz6V85mpq6X1cGul8U7jjaAl1PWpg==";
            Assert.Equal(expectedCipherText, actualCipherText);
        }

        [Fact(DisplayName = "测试用例：工具类 `SM4Utility.DecryptWithCBC`")]
        public void TestSM4Decrypt()
        {
            const string key = "MDAwMDAwMDAwMDAwMDAwMA==";
            const string iv = "OGE2YzRkZGQ4YTZjNGRkZA==";
            const string cipherText = "Fm3z4Ipjuaj4oQLfxpTrvoZm5JdbjvjrJo3PRhvSsOppk8/PN+izH3Wo9Rz6V85mpq6X1cGul8U7jjaAl1PWpg==";

            string actualPlainText = Utilities.SM4Utility.DecryptWithCBC(encodingKey: (EncodedString)key, encodingIV: (EncodedString)iv, encodingCipher: (EncodedString)cipherText)!;
            string expectedPlainText = "Awesome SKIT.FlurlHttpClient.Wechat.TenpayBusiness!";
            Assert.Equal(expectedPlainText, actualPlainText);
        }
    }
}
