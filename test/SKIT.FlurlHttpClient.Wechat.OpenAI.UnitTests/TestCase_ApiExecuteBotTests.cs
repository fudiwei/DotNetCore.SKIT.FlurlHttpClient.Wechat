using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class TestCase_ApiExecuteBotTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /v2/bot/query")]
        public async Task TestExecuteTokenV2()
        {
            var request = new Models.BotQueryV2Request()
            {
                QueryString = "我叫我妈妈的姐姐叫什么？",
                Environment = "debug",
                UserId = "TEST_USERID",
                UserName = "TEST_USERNAME",
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.OpenAIInstance.ExecuteBotQueryV2Async(request);

            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.MessageId);
            Assert.NotNull(response.Data.AnswerType);
            Assert.NotNull(response.Data.Answer);
            Assert.NotNull(response.Data.Status);
        }
    }
}
