using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinTests
    {
        [Fact(DisplayName = "[GET] /cgi-bin/token")]
        public async Task CgibinTokenTest()
        {
            var request = new Models.CgibinTokenRequest();
            var response = await TestClients.Instance.ExecuteCgibinTokenAsync(request);

            Assert.NotNull(response.AccessToken);
        }

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

        [Fact(DisplayName = "[POST] /cgi-bin/clear_quota")]
        public async Task CgibinClearQuotaTest()
        {
            var request = new Models.CgibinClearQuotaRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinClearQuotaAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
