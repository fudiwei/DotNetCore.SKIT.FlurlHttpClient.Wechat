namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinTagsTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/tags/create）")]
        public async Task TestExecuteCgibinTagsCreate()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinTagsCreateRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                Tag = new Models.CgibinTagsCreateRequest.Types.Tag()
                {
                    Name = "FAKE_TAGNAME"
                }
            };
            var response = await client.ExecuteCgibinTagsCreateAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Tag);
            Assert.True(response.Tag.Id > 0);
            Assert.Equal(request.Tag.Name, response.Tag.Name);
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/tags/get）")]
        public async Task TestExecuteCgibinTagsGet()
        {
            CompactAssert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinTagsGetRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinTagsGetAsync(request, CompactTestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Tags);
            Assert.NotEmpty(response.Tags);
            Assert.True(response.Tags.First().Id > 0);
            Assert.NotNull(response.Tags.First().Name);
        }
    }
}
