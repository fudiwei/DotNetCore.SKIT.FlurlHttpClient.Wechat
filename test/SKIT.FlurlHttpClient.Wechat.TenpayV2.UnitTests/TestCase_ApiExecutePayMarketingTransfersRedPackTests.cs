using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class TestCase_ApiExecutePayMarketingTransfersRedPackTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /mmpaymkttransfers/sendgroupredpack")]
        public async Task TestCase_ApiExecuteSendPayMarketingTransfersGroupRedPackTests()
        {
            var request = new Models.SendPayMarketingTransfersGroupRedPackRequest()
            {
                ActivityName = "TEST_ACT",
                MerchantBillNumber = "TESTMBN" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = TestConfigs.WechatAppId,
                OpenId = TestConfigs.WechatOpenId,
                SenderName = "TEST_SENDER",
                TotalAmount = 100,
                TotalCount = 10,
                Wishing = "TEST_WISH",
                ClientIp = "127.0.0.7"
            };
            var response = await TestClients.Instance.ExecuteSendPayMarketingTransfersGroupRedPackAsync(request);

            Assert.NotNull(response.PartnerTradeNumber);
        }
    }
}
