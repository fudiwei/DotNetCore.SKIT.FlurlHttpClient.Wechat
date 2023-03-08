using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    using SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance;
    using SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models;

    public class TestCase_FinanceSdkTests
    {
        [Fact(DisplayName = "测试用例：会话内容存档 SDK")]
        public async Task TestFinanceSdk()
        {
            using var client = new WechatWorkFinanceClient(new WechatWorkFinanceClientOptions()
            {
                CorpId = TestConfigs.WechatCorpId,
                SecretKey = TestConfigs.WechatFinanceSecretKey,
                RsaPrivateKey = TestConfigs.WechatFinanceRsaPrivateKey
            });

            var reqGetChatData = new GetChatDataRequest();
            var resGetChatData = await client.ExecuteGetChatDataAsync(reqGetChatData);

            Assert.True(resGetChatData.IsSuccessful());
        }
    }
}
