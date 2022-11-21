using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class TestCase_ApiExecuteDialogTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /sign/{TOKEN}")]
        public async Task TestExecuteSign()
        {
            var request = new Models.SignRequest() { UserId = "TEST_USERID" };
            var response = await TestClients.Instance.ExecuteSignAsync(request);

            Assert.NotNull(response.Signature);
        }
    }
}
