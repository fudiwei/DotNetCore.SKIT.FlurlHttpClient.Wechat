using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteCgibinTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/token")]
        public async Task TestExecuteCgibinToken()
        {
            var request = new Models.CgibinTokenRequest();
            var response = await TestClients.Instance.ExecuteCgibinTokenAsync(request);

            Assert.NotNull(response.AccessToken);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/ticket/getticket")]
        public async Task TestExecuteCgibinTicketGetTicket()
        {
            var request = new Models.CgibinTicketGetTicketRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinTicketGetTicketAsync(request);

            Assert.NotNull(response.Ticket);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/getcallbackip")]
        public async Task TestExecuteCgibinGetCallbackIp()
        {
            var request = new Models.CgibinGetCallbackIpRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinGetCallbackIpAsync(request);

            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/get_api_domain_ip")]
        public async Task TestExecuteCgibinGetApiDomainIp()
        {
            var request = new Models.CgibinGetApiDomainIpRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinGetApiDomainIpAsync(request);

            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/clear_quota")]
        public async Task TestExecuteCgibinClearQuota()
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
