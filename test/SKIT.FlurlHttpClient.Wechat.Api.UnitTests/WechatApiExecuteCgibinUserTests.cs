using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinUserTests
    {
        [Fact(DisplayName = "[GET] /cgi-bin/user/info")]
        public async Task CgibinUserInfoTest()
        {
            var request = new Models.CgibinUserInfoRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                OpenId = TestConfigs.WechatOpenId
            };
            var response = await TestClients.Instance.ExecuteCgibinUserInfoAsync(request);

            Assert.NotEmpty(response.OpenId);
            Assert.NotEmpty(response.Nickname);
            Assert.True(response.IsSubscribed);
        }

        [Fact(DisplayName = "[POST] /cgi-bin/user/info/batchget")]
        public async Task CgibinUserInfoBatchGetTest()
        {
            var request = new Models.CgibinUserInfoBatchGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                UserList = new Models.CgibinUserInfoBatchGetRequest.Types.User[] 
                { 
                    new Models.CgibinUserInfoBatchGetRequest.Types.User() { OpenId = TestConfigs.WechatOpenId }
                }
            };
            var response = await TestClients.Instance.ExecuteCgibinUserInfoBatchGetAsync(request);

            Assert.NotEmpty(response.UserList);
            Assert.NotEmpty(response.UserList.First().OpenId);
            Assert.NotEmpty(response.UserList.First().Nickname);
            Assert.True(response.UserList.First().IsSubscribed);
        }

        [Fact(DisplayName = "[POST] /cgi-bin/user/info/updateremark")]
        public async Task CgibinUserInfoUpdateRemarkTest()
        {
            var request = new Models.CgibinUserInfoUpdateRemarkRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                OpenId = TestConfigs.WechatOpenId,
                Remark = "FAKE_REMARK"
            };
            var response = await TestClients.Instance.ExecuteCgibinUserInfoUpdateRemarkAsync(request);

            Assert.Equal(0, response.ErrorCode);
        }

        [Fact(DisplayName = "[GET] /cgi-bin/user/get")]
        public async Task CgibinUserGetTest()
        {
            var request = new Models.CgibinUserGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinUserGetAsync(request);

            Assert.NotEmpty(response.Data.OpenIdList);
            Assert.True(response.Total > 0);
            Assert.True(response.Count > 0);
        }
    }
}
