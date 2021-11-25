using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayExecuteProfitSharingTests
    {
        [Fact(DisplayName = "[POST] /profitsharing/receivers/add")]
        public async Task AddProfitSharingReceiverTest()
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
            TestClients.Instance.EncryptRequestSensitiveProperty(request);
            var response = await TestClients.Instance.ExecuteAddProfitSharingReceiverAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
