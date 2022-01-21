using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteCgibinMessageMassTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/message/mass/send")]
        public async Task TestExecuteCgibinMessageMassSend()
        {
            var request = new Models.CgibinMessageMassSendRequest()
            {
                ToUserOpenIdList = new string[] { TestConfigs.WechatOpenId, TestConfigs.WechatOpenId },
                MessageType = "text",
                MessageContentForText = new Models.CgibinMessageMassSendRequest.Types.TextMessage()
                {
                    Content = "FAKE_CONTENT"
                },
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinMessageMassSendAsync(request);

            Assert.True(response.MessageId > 0);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/message/mass/preview")]
        public async Task TestExecuteCgibinMessageMassPreview()
        {
            var request = new Models.CgibinMessageMassPreviewRequest()
            {
                ToUserOpenId = TestConfigs.WechatOpenId,
                MessageType = "text",
                MessageContentForText = new Models.CgibinMessageMassPreviewRequest.Types.TextMessage()
                {
                    Content = "FAKE_CONTENT"
                },
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinMessageMassPreviewAsync(request);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/message/mass/speed/get")]
        public async Task TestExecuteCgibinMessageMassSpeedGet()
        {
            var request = new Models.CgibinMessageMassSpeedGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinMessageMassSpeedGetAsync(request);

            Assert.True(response.SpeedLevel > 0);
            Assert.True(response.SpeedValue > 0);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/message/mass/speed/set")]
        public async Task TestExecuteCgibinMessageMassSpeedSet()
        {
            var request = new Models.CgibinMessageMassSpeedSetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                SpeedLevel = 1
            };
            var response = await TestClients.Instance.ExecuteCgibinMessageMassSpeedSetAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
