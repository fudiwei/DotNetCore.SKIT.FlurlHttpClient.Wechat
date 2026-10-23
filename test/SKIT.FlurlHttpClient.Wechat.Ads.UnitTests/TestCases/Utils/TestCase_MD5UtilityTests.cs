namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests.TestCases.Utils
{
    public class TestCase_Util_MD5UtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `MD5Utility.Hash`")]
        public void TestMD5Hash()
        {
            const string message = "spidbff89d5138160943040012345678901234567890uFolxxiZbrZ/PRbyen5uK5D1kgIB2yHyDsfDGxxgeG";

            string expectedHash = "32c03e8fcdb08e653e42805e302f70ed";
            string actualHash = Utilities.MD5Utility.Hash(message)!;
            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
