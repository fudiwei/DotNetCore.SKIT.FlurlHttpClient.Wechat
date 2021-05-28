using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinMessageMassTests
    {
        [Fact(DisplayName = "[POST] /cgi-bin/message/mass/send")]
        public async Task CgibinMessageMassSendTest()
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

        [Fact(DisplayName = "[POST] /cgi-bin/message/mass/preview")]
        public async Task CgibinMessageMassPreviewTest()
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

        [Fact(DisplayName = "[GET] /cgi-bin/message/mass/speed/get")]
        public async Task CgibinMessageMassSpeedGetTest()
        {
            var request = new Models.CgibinMessageMassSpeedGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinMessageMassSpeedGetAsync(request);

            Assert.True(response.SpeedLevel > 0);
            Assert.True(response.SpeedValue > 0);
        }

        [Fact(DisplayName = "[POST] /cgi-bin/message/mass/speed/set")]
        public async Task CgibinMessageMassSpeedSetTest()
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
