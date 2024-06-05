using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class TestCase_ApiExecuteTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /v2/token")]
        public async Task TestExecuteTokenV2()
        {
            var request = new Models.TokenV2Request() { AccountId = TestConfigs.WechatAccountId };
            var response = await TestClients.OpenAIInstance.ExecuteTokenV2Async(request);

            Assert.NotNull(response.Data?.AccessToken);
        }
    }
}
