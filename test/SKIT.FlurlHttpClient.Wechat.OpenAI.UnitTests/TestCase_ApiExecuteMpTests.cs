using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class TestCase_ApiExecuteMpTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /getbindlink/{TOKEN}")]
        public async Task TestExecuteSign()
        {
            var request = new Models.GetBindLinkRequest() { RedirectUrl = "https://example.com" };
            var response = await TestClients.Instance.ExecuteGetBindLinkAsync(request);

            Assert.NotNull(response.LinkUrl);
        }
    }
}
