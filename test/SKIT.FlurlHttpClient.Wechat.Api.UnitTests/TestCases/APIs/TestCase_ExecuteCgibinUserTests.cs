namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinUserTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/user/info）")]
        public async Task TestExecuteCgibinUserInfo()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinUserInfoRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                OpenId = ITConfigs.Fixtures_OpenId
            };
            var response = await client.ExecuteCgibinUserInfoAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.OpenId);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/user/info/batchget）")]
        public async Task TestExecuteCgibinUserInfoBatchGet()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinUserInfoBatchGetRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                UserList = new List<Models.CgibinUserInfoBatchGetRequest.Types.User>()
                {
                    new Models.CgibinUserInfoBatchGetRequest.Types.User()
                    {
                        OpenId = ITConfigs.Fixtures_OpenId
                    }
                }
            };
            var response = await client.ExecuteCgibinUserInfoBatchGetAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.UserList);
            Assert.NotEmpty(response.UserList);
            Assert.NotNull(response.UserList.First().OpenId);
            Assert.True(response.UserList.First().IsSubscribed);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/user/info/updateremark）")]
        public async Task TestExecuteCgibinUserInfoUpdateRemark()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");
            CompactAssert.SkipWhen("" == ITConfigs.Fixtures_OpenId, "【已跳过】未配置 \"Fixtures.OpenId\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinUserInfoUpdateRemarkRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                OpenId = ITConfigs.Fixtures_OpenId,
                Remark = "FAKE_REMARK"
            };
            var response = await client.ExecuteCgibinUserInfoUpdateRemarkAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/user/get）")]
        public async Task TestExecuteCgibinUserGet()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinUserGetRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinUserGetAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.OpenIdList);
            Assert.NotEmpty(response.Data.OpenIdList);
            Assert.True(response.Total > 0);
            Assert.True(response.Count > 0);
        }
    }
}
