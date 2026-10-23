namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests.TestCases.Utils
{
    public class TestCase_SHA256UtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `SHA256Utility.Hash`")]
        public void TestSHA256Hash()
        {
            const string message = "SHA256HashTest";

            string expectedHash = "8446f1ce5ca8b4a87c0d0cc15be4ba173b2ff78dc33c5f6731d877dcd2d8f401";
            string actualHash = Utilities.SHA256Utility.Hash(message)!;
            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
