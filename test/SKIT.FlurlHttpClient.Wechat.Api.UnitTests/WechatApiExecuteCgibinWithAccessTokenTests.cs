using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinWithAccessTokenTests
    {
        [Fact(DisplayName = "[GET] /cgi-bin/ticket/getticket")]
        public async Task CgibinTicketGetTicketTest()
        {
            var request = new Models.CgibinTicketGetTicketRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinTicketGetTicketAsync(request);

            Assert.NotNull(response.Ticket);
        }

        [Fact(DisplayName = "[GET] /cgi-bin/getcallbackip")]
        public async Task CgibinGetCallbackIpTest()
        {
            var request = new Models.CgibinGetCallbackIpRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinGetCallbackIpAsync(request);

            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "[GET] /cgi-bin/get_api_domain_ip")]
        public async Task CgibinGetApiDomainIpTest()
        {
            var request = new Models.CgibinGetApiDomainIpRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinGetApiDomainIpAsync(request);

            Assert.NotEmpty(response.IPList);
        }

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
            Assert.True(response.Subscribe == 1);
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
            Assert.True(response.UserList.First().Subscribe == 1);
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

        [Fact(DisplayName = "[GET] /cgi-bin/user")]
        public async Task CgibinUserTest()
        {
            var request = new Models.CgibinUserRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinUserAsync(request);

            Assert.NotEmpty(response.Data.OpenIdList);
            Assert.True(response.Total > 0);
            Assert.True(response.Count > 0);
        }

        [Fact(DisplayName = "[POST] /cgi-bin/tags/create")]
        public async Task CgibinTagsCreateTest()
        {
            var request = new Models.CgibinTagsCreateRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                Tag = new Models.CgibinTagsCreateRequest.Types.Tag() 
                { 
                    Name = "FAKE_TAGNAME" 
                }
            };
            var response = await TestClients.Instance.ExecuteCgibinTagsCreateAsync(request);

            Assert.True(response.Tag.Id > 0);
            Assert.Equal(request.Tag.Name, response.Tag.Name);
        }

        [Fact(DisplayName = "[POST] /cgi-bin/tags/get")]
        public async Task CgibinTagsGetTest()
        {
            var request = new Models.CgibinTagsGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinTagsGetAsync(request);

            Assert.NotEmpty(response.Tags);
            Assert.True(response.Tags.First().Id > 0);
            Assert.NotNull(response.Tags.First().Name);
        }
    }
}
