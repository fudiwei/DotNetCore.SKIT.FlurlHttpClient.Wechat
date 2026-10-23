namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteBotTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /v2/bot/query）")]
        public async Task TestExecuteTokenV2()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");
            Assert.SkipWhen("" == ITConfigs.Fixtures_UserId, "【已跳过】未配置 \"Fixtures.UserId\"。");
            Assert.SkipWhen("" == ITConfigs.Fixtures_UserName, "【已跳过】未配置 \"Fixtures.UserName\"。");

            using var client = ITClients.CreateOpenAIInstance();
            var request = new Models.BotQueryV2Request()
            {
                QueryString = "我叫我妈妈的姐姐叫什么？",
                Environment = "debug",
                UserId = ITConfigs.Fixtures_UserId,
                UserName = ITConfigs.Fixtures_UserName,
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteBotQueryV2Async(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.MessageId);
            Assert.NotNull(response.Data.AnswerType);
            Assert.NotNull(response.Data.Answer);
            Assert.NotNull(response.Data.Status);
        }
    }
}
