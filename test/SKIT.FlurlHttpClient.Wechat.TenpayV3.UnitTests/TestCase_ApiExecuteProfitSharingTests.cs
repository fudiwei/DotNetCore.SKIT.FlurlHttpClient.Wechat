using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteProfitSharingTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /profitsharing/receivers/add")]
        public async Task TestExecuteAddProfitSharingReceiver()
        {
            await TestClients.InitializeCertificateManagerAsync();

            var request = new Models.AddProfitSharingReceiverRequest()
            {
                AppId = TestConfigs.WechatAppId,
                Account = TestConfigs.WechatOpenId,
                RelationType = "DISTRIBUTOR",
                Name = "NAME",
                Type = "PERSONAL_OPENID"
            };
            TestClients.InstanceUseRSA.EncryptRequestSensitiveProperty(request);
            var response = await TestClients.InstanceUseRSA.ExecuteAddProfitSharingReceiverAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
