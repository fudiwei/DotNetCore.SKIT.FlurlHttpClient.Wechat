using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    using SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance;

    public class TestCase_FinanceSdkTests
    {
        [Fact(DisplayName = "测试用例：会话内容存档 SDK")]
        public async Task TestFinanceSdk()
        {
            using var client = new WechatWorkFinanceClient(new WechatWorkFinanceClientOptions()
            {
                CorpId = "",
                SecretKey = ""
            });

            client.Dispose();
            Assert.NotNull(client);
        }
    }
}
