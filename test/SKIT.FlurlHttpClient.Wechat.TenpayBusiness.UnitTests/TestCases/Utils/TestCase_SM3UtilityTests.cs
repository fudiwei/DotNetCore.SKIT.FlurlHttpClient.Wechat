namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests.TestCases.Utils
{
    public class TestCase_SM3UtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `SM3Utility.Hash`")]
        public void TestSM3Hash()
        {
            byte[] msgBytes = Convert.FromBase64String("QXdlc29tZSBTS0lULkZsdXJsSHR0cENsaWVudC5XZWNoYXQuVGVucGF5QnVzaW5lc3Mh");

            string expectedHash = "A7A58FCEDDDEE4BD2E05887E5F4D8B7D662357BE474F3821CA858EE1CFFB4B83";
            string actualHash = BitConverter.ToString(Utilities.SM3Utility.Hash(msgBytes)).Replace("-", "");
            Assert.Equal(actualHash, expectedHash, ignoreCase: true);
        }
    }
}
