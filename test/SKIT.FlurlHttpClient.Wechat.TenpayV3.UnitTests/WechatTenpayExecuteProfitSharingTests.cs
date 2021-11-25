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
            var cert = TestClients.Instance.DecryptResponseSensitiveProperty(await TestClients.Instance.ExecuteQueryCertificatesAsync(new Models.QueryCertificatesRequest()));
            foreach (var certificateModel in cert.CertificateList)
            {
                TestClients.GlobalCertificateManager.AddEntry(new Settings.CertificateEntry(certificateModel));
            }

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
