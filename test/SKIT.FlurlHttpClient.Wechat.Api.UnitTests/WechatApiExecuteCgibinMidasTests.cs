using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinMidasTests
    {
        [Fact(DisplayName = "米大师请求签名")]
        public async Task MidasSigTest()
        {
            var client = new WechatApiClient(new WechatApiClientOptions()
            { 
                AppId = "wx1234567",
                AppSecret = "",
                MidasAppKey = "zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u"
            });
            var request = new Models.CgibinMidasGetBalanceRequest()
            {
                OpenId = "odkx20ENSNa2w5y3g_qOkOvBNM1g",
                MidasOfferId = "12345678",
                MidasZoneId = "1",
                Platform = "android",
                Timestamp = 1507530737
            };
            var response = await client.ExecuteCgibinMidasGetBalanceAsync(request);

            Assert.Equal("1ad64e8dcb2ec1dc486b7fdf01f4a15159fc623dc3422470e51cf6870734726b", request.Signature, ignoreCase: true);
        }
    }
}
