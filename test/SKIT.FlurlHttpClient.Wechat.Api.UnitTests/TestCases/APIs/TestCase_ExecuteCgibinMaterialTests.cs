namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteCgibinMaterialTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /cgi-bin/material/get_materialcount）")]
        public async Task TestExecuteCgibinMaterialGetMaterialCount()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinMaterialGetMaterialCountRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken
            };
            var response = await client.ExecuteCgibinMaterialGetMaterialCountAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API（[POST] /cgi-bin/material/batchget_material）")]
        public async Task TestExecuteCgibinMaterialBatchGetMaterial()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AccessToken, "【已跳过】未配置 \"Credentials.AccessToken\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CgibinMaterialBatchGetMaterialRequest()
            {
                AccessToken = ITConfigs.Credentials_AccessToken,
                Type = "news"
            };
            var response = await client.ExecuteCgibinMaterialBatchGetMaterialAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.MaterialList);
        }
    }
}
