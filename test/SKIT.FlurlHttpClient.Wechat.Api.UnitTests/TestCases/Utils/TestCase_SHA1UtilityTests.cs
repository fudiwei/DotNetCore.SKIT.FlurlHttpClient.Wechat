namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.Utils
{
    public class TestCase_SHA1UtilityTests
    {
        [Fact(DisplayName = "测试用例：工具类 `SHA1Utility.Hash`")]
        public void TestSHA1Hash()
        {
            const string message = "jsapi_ticket=HoagFKDcsGMVCIY2vOjf9nGrZ3eaM0qXs5ROFN_3k_HrGc0VocemA6wMXkvrL-Ei4IitXxwKF62CJWR8mWXZ3Q&noncestr=e7b435f73835402da44f16640ddc8696&timestamp=1621348162&url=https://mp.weixin.qq.com/debug/cgi-bin/sandbox?t=jsapisign";

            string expectedHash = "b214ea1f8ae019c207f8c6ffb843c8474cbab28c";
            string actualHash = Utilities.SHA1Utility.Hash(message)!;
            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
