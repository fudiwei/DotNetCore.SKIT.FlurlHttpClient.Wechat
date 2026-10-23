namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.Utils
{
    public class TestCase_HMACUtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `HMACUtility.HashWithSHA256`")]
        public void TestHMACHashWithSHA256()
        {
            const string secret = "zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u";
            const string message = "appid=wx1234567&offer_id=12345678&openid=odkx20ENSNa2w5y3g_qOkOvBNM1g&pf=android&ts=1507530737&zone_id=1&org_loc=/cgi-bin/midas/getbalance&method=POST&secret=zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u";

            string expectedHash = "1ad64e8dcb2ec1dc486b7fdf01f4a15159fc623dc3422470e51cf6870734726b";
            string actualHash = Utilities.HMACUtility.HashWithSHA256(secret, message)!;
            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
