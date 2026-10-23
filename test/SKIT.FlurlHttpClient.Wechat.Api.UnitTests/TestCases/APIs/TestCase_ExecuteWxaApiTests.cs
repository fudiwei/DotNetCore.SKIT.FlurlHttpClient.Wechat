namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteWxaApiTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /wxaapi/log/jserr_list）")]
        public async Task TestExecuteWxaApiLogGetPerformance()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.WxaApiLogGetPerformanceRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                CostTimeType = 1,
                StartTimestamp = DateTimeOffset.Parse("2021-01-01").ToUnixTimeSeconds(),
                EndTimestamp = DateTimeOffset.Parse("2021-01-31").ToUnixTimeSeconds()
            };
            var response = await client.ExecuteWxaApiLogGetPerformanceAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.DefaultTimeData);
            Assert.NotEmpty(response.DefaultTimeData!.DataList);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /wxaapi/log/get_scene）")]
        public async Task TestExecuteWxaApiLogGetScene()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.WxaApiLogGetSceneRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteWxaApiLogGetSceneAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.SceneDataList);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /wxaapi/log/get_client_version）")]
        public async Task TestExecuteWxaApiLogGetClientVersion()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.WxaApiLogGetClientVersionRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteWxaApiLogGetClientVersionAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.ClientVersionDataList);
        }
    }
}
