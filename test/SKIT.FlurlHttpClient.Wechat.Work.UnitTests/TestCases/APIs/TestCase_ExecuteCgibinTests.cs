namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/gettoken）")]
        public async Task TestExecuteCgibinToken()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_CorpId, "【已跳过】未配置 \"Credentials.CorpId\"。");
            CompactAssert.SkipWhen(0 == ITConfigs.Credentials_AgentId, "【已跳过】未配置 \"Credentials.AgentId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AgentSecret, "【已跳过】未配置 \"Credentials.AgentSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinGetTokenRequest();
            var response = await client.ExecuteCgibinGetTokenAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.AccessToken);
        }
    }
}
