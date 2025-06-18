using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteSnsWithAppSecretTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /sns/oauth2/access_token")]
        public async Task TestExecuteSnsOAuth2AccessToken()
        {
            var request = new Models.SnsOAuth2AccessTokenRequest()
            {
                Code = "FAKE_CODE"
            };
            var response = await TestClients.Instance.ExecuteSnsOAuth2AccessTokenAsync(request);

            Assert.NotNull(response.AccessToken);
            Assert.NotNull(response.RefreshToken);
            Assert.NotNull(response.OpenId);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /sns/oauth2/refresh_token")]
        public async Task TestExecuteSnsOAuth2RefreshToken()
        {
            var request = new Models.SnsOAuth2RefreshTokenRequest()
            {
                RefreshToken = "FAKE_REFRESHTOKEN"
            };
            var response = await TestClients.Instance.ExecuteSnsOAuth2RefreshTokenAsync(request);

            Assert.NotNull(response.AccessToken);
            Assert.NotNull(response.RefreshToken);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /sns/jscode2session")]
        public async Task TestExecuteSnsJsCode2Session()
        {
            var request = new Models.SnsJsCode2SessionRequest()
            {
                JsCode = "FAKE_CODE"
            };
            var response = await TestClients.Instance.ExecuteSnsJsCode2SessionAsync(request);

            Assert.NotNull(response.OpenId);
            Assert.NotNull(response.SessionKey);
        }
    }
}
