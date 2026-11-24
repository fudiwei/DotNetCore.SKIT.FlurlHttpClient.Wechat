namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteSnsWithAccessTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /sns/userinfo）")]
        public async Task TestExecuteSnsUserInfo()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.SnsUserInfoRequest()
            {
                AccessToken = "FAKE_SNSACCESSTOKEN",
                OpenId = ITConfigs.Fixtures_OpenId
            };
            var response = await client.ExecuteSnsUserInfoAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.OpenId);
            Assert.NotNull(response.Nickname);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /sns/auth）")]
        public async Task TestExecuteSnsAuth()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.SnsAuthRequest()
            {
                AccessToken = "FAKE_SNSACCESSTOKEN",
                OpenId = ITConfigs.Fixtures_OpenId
            };
            var response = await client.ExecuteSnsAuthAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
