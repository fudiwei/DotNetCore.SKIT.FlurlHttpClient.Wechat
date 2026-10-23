namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /v2/token）")]
        public async Task TestExecuteTokenV2()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Fixtures_AccountId, "【已跳过】未配置 \"Fixtures.AccountId\"。");

            using var client = ITClients.CreateOpenAIInstance();
            var request = new Models.TokenV2Request()
            {
                AccountId = ITConfigs.Fixtures_AccountId
            };
            var response = await client.ExecuteTokenV2Async(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.AccessToken);
        }
    }
}
