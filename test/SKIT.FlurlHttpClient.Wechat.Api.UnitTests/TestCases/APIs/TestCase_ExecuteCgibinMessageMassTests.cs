namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinMessageMassTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/message/mass/preview）")]
        public async Task TestExecuteCgibinMessageMassPreview()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinMessageMassPreviewRequest()
            {
                ToUserOpenId = ITConfigs.Fixtures_OpenId,
                MessageType = "text",
                MessageContentForText = new Models.CgibinMessageMassPreviewRequest.Types.TextMessage()
                {
                    Content = "FAKE_CONTENT"
                },
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinMessageMassPreviewAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/message/mass/speed/get）")]
        public async Task TestExecuteCgibinMessageMassSpeedGet()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinMessageMassSpeedGetRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinMessageMassSpeedGetAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.True(response.SpeedLevel > 0);
            Assert.True(response.SpeedValue > 0);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/message/mass/speed/set）")]
        public async Task TestExecuteCgibinMessageMassSpeedSet()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinMessageMassSpeedSetRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                SpeedLevel = 1
            };
            var response = await client.ExecuteCgibinMessageMassSpeedSetAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
