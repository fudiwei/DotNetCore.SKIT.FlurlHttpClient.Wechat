using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class TestCase_ApiExecuteExecutePayTransactionsTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /pay/micropay")]
        public async Task TestCase_ApiExecuteExecutePayTests()
        {
            var request = new Models.CreatePayMicroPayRequest()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                Body = "TEST_BODY",
                TotalFee = 1,
                ClientIp = "127.0.0.7",
                AuthCode = "TEST_AUTH_CODE"
            };
            var response = await TestClients.Instance.ExecuteCreatePayMicroPayAsync(request);

            Assert.NotNull(response.ReturnCode);
            Assert.NotNull(response.ReturnMessage);
            Assert.NotNull(response.TransactionId);
        }
    }
}
