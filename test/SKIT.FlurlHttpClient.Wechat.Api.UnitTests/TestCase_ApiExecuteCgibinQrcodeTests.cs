using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteCgibinQrcodeTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/qrcode/create")]
        public async Task TestExecuteCgibinQrcodeCreate()
        {
            var request = new Models.CgibinQrcodeCreateRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
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
            var response = await TestClients.Instance.ExecuteCgibinQrcodeCreateAsync(request);

            Assert.NotNull(response.Ticket);
            Assert.NotNull(response.Url);
        }
    }
}
