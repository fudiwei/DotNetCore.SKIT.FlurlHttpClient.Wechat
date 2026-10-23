namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/token）")]
        public async Task TestExecuteCgibinToken()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinTokenRequest();
            var response = await client.ExecuteCgibinTokenAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.AccessToken);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/stable_token）")]
        public async Task TestExecuteCgibinStableToken()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinStableTokenRequest();
            var response = await client.ExecuteCgibinStableTokenAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.AccessToken);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/ticket/getticket）")]
        public async Task TestExecuteCgibinTicketGetTicket()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinTicketGetTicketRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinTicketGetTicketAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Ticket);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/getcallbackip）")]
        public async Task TestExecuteCgibinGetCallbackIp()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinGetCallbackIpRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinGetCallbackIpAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.IPList);
            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/get_api_domain_ip）")]
        public async Task TestExecuteCgibinGetApiDomainIp()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinGetApiDomainIpRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinGetApiDomainIpAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.IPList);
            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/clear_quota）")]
        public async Task TestExecuteCgibinClearQuota()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinClearQuotaRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinClearQuotaAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
