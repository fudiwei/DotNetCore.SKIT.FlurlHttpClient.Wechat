using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteWxaApiTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /wxaapi/log/jserr_list")]
        public async Task TestExecuteWxaApiLogGetPerformance()
        {
            var request = new Models.WxaApiLogGetPerformanceRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                CostTimeType = 1,
                StartTimestamp = DateTimeOffset.Parse("2021-01-01").ToUnixTimeSeconds(),
                EndTimestamp = DateTimeOffset.Parse("2021-01-31").ToUnixTimeSeconds()
            };
            var response = await TestClients.Instance.ExecuteWxaApiLogGetPerformanceAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.DefaultTimeData);
            Assert.NotEmpty(response.DefaultTimeData.DataList);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /wxaapi/log/get_scene")]
        public async Task TestExecuteWxaApiLogGetScene()
        {
            var request = new Models.WxaApiLogGetSceneRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteWxaApiLogGetSceneAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.SceneDataList);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /wxaapi/log/get_client_version")]
        public async Task TestExecuteWxaApiLogGetClientVersion()
        {
            var request = new Models.WxaApiLogGetClientVersionRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteWxaApiLogGetClientVersionAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.ClientVersionDataList);
        }
    }
}
