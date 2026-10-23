namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteDialogTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /sign/{TOKEN}）")]
        public async Task TestExecuteSign()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Fixtures_UserId, "【已跳过】未配置 \"Fixtures.UserId\"。");

            using var client = ITClients.CreateChatbotInstance();
            var request = new Models.SignRequest()
            {
                UserId = ITConfigs.Fixtures_UserId
            };
            var response = await client.ExecuteSignAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Signature);
        }
    }
}
