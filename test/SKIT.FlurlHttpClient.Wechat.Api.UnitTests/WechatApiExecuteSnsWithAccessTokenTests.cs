using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteSnsWithAccessTokenTests
    {
        [Fact(DisplayName = "[GET] /sns/userinfo")]
        public async Task SnsUserInfoTest()
        {
            var request = new Models.SnsUserInfoRequest()
            {
                AccessToken = "FAKE_SNSACCESSTOKEN",
                OpenId = TestConfigs.WechatOpenId
            };
            var response = await TestClients.Instance.ExecuteSnsUserInfoAsync(request);

            Assert.NotNull(response.OpenId);
            Assert.NotNull(response.Nickname);
        }

        [Fact(DisplayName = "[GET] /sns/auth")]
        public async Task SnsAuthTest()
        {
            var request = new Models.SnsAuthRequest()
            {
                AccessToken = "FAKE_SNSACCESSTOKEN",
                OpenId = TestConfigs.WechatOpenId
            };
            var response = await TestClients.Instance.ExecuteSnsAuthAsync(request);

            Assert.Equal(0, response.ErrorCode);
        }
    }
}
