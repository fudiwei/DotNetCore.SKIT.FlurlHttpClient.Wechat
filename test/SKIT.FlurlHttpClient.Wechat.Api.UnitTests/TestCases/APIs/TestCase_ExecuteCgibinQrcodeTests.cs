namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinQrcodeTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/qrcode/create）")]
        public async Task TestExecuteCgibinQrcodeCreate()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinQrcodeCreateRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                ExpiresIn = 30,
                ActionType = "QR_STR_SCENE",
                Action = new Models.CgibinQrcodeCreateRequest.Types.Action()
                {
                    Scene = new Models.CgibinQrcodeCreateRequest.Types.Action.Types.Scene()
                    {
                        SceneString = "FAKE_SCENESTR"
                    }
                }
            };
            var response = await client.ExecuteCgibinQrcodeCreateAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Ticket);
            Assert.NotNull(response.Url);
        }
    }
}
