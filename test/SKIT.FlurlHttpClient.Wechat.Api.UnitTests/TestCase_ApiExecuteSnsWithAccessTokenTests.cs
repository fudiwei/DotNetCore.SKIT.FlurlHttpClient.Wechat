using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteSnsWithAccessTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /sns/userinfo")]
        public async Task TestExecuteSnsUserInfo()
        {
            var request = new Models.SnsUserInfoRequest()
            {
                AccessToken = "FAKE_SNSACCESSTOKEN",
                OpenId = TestConfigs.WechatOpenId
            };
            var response = await TestClients.Instance.ExecuteSnsUserInfoAsync(request);

            Assert.NotNull(response.OpenId);
            Assert.NotNull(response.Nickname);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /sns/auth")]
        public async Task TestExecuteSnsAuth()
        {
            var request = new Models.SnsAuthRequest()
            {
                AccessToken = "FAKE_SNSACCESSTOKEN",
                OpenId = TestConfigs.WechatOpenId
            };
            var response = await TestClients.Instance.ExecuteSnsAuthAsync(request);

            Assert.Equal(0, response.ErrorCode);
        }
    }
}
