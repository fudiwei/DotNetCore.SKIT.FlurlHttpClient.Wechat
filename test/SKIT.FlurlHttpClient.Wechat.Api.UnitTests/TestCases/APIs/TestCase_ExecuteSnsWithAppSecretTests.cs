namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteSnsWithAppSecretTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /sns/oauth2/access_token）")]
        public async Task TestExecuteSnsOAuth2AccessToken()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.SnsOAuth2AccessTokenRequest()
            {
                Code = "FAKE_CODE"
            };
            var response = await client.ExecuteSnsOAuth2AccessTokenAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.OpenId);
            Assert.NotNull(response.AccessToken);
            Assert.NotNull(response.RefreshToken);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /sns/oauth2/refresh_token）")]
        public async Task TestExecuteSnsOAuth2RefreshToken()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.SnsOAuth2RefreshTokenRequest()
            {
                RefreshToken = "FAKE_REFRESHTOKEN"
            };
            var response = await client.ExecuteSnsOAuth2RefreshTokenAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.AccessToken);
            Assert.NotNull(response.RefreshToken);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /sns/jscode2session）")]
        public async Task TestExecuteSnsJsCode2Session()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 WechatAppId。");
            Assert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 WechatAppSecret。");

            using var client = ITClients.CreateInstance();
            var request = new Models.SnsJsCode2SessionRequest()
            {
                JsCode = "FAKE_CODE"
            };
            var response = await client.ExecuteSnsJsCode2SessionAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.OpenId);
            Assert.NotNull(response.SessionKey);
        }
    }
}
