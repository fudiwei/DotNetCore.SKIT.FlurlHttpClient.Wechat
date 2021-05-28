using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinQrcodeTests
    {
        [Fact(DisplayName = "[POST] /cgi-bin/qrcode/create")]
        public async Task CgibinQrcodeCreateTest()
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
