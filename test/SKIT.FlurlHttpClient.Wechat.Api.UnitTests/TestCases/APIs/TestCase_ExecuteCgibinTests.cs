namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/token）")]
        public async Task TestExecuteCgibinToken()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinTokenRequest();
            var response = await client.ExecuteCgibinTokenAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.AccessToken);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/stable_token）")]
        public async Task TestExecuteCgibinStableToken()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinStableTokenRequest();
            var response = await client.ExecuteCgibinStableTokenAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.AccessToken);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/ticket/getticket）")]
        public async Task TestExecuteCgibinTicketGetTicket()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinTicketGetTicketRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinTicketGetTicketAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Ticket);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/getcallbackip）")]
        public async Task TestExecuteCgibinGetCallbackIp()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinGetCallbackIpRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinGetCallbackIpAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.IPList);
            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/get_api_domain_ip）")]
        public async Task TestExecuteCgibinGetApiDomainIp()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinGetApiDomainIpRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinGetApiDomainIpAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.IPList);
            Assert.NotEmpty(response.IPList);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/clear_quota）")]
        public async Task TestExecuteCgibinClearQuota()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinClearQuotaRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinClearQuotaAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
