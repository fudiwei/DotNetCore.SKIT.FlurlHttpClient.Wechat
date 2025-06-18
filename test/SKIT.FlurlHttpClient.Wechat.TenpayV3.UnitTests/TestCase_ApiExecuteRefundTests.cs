using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteRefundTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /refund/domestic/refunds")]
        public async Task TestExecuteCreateRefundDomesticRefund()
        {
            var request = new Models.CreateRefundDomesticRefundRequest()
            {
                OutTradeNumber = "FAKE_OUTTRADENO",
                OutRefundNumber = "TEST_ORN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                Amount = new Models.CreateRefundDomesticRefundRequest.Types.Amount()
                {
                    Total = 1,
                    Refund = 1
                },
                Reason = "FAKE_REASON"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteCreateRefundDomesticRefundAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.OutRefundNumber);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.Channel);
            Assert.NotNull(response.Status);
            Assert.True(response.Amount.Total > 0);
            Assert.True(response.Amount.Refund > 0);
            Assert.True(response.Amount.PayerTotal > 0);
            Assert.True(response.Amount.PayerRefund > 0);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /refund/domestic/refunds/{out_refund_no}")]
        public async Task TestExecuteGetRefundDomesticRefundByOutRefundNumber()
        {
            var request = new Models.GetRefundDomesticRefundByOutRefundNumberRequest()
            {
                OutRefundNumber = "FAKE_OUTREFUNDNO"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteGetRefundDomesticRefundByOutRefundNumberAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.RefundId);
            Assert.NotNull(response.OutRefundNumber);
            Assert.NotNull(response.TransactionId);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.Channel);
            Assert.NotNull(response.Status);
            Assert.NotNull(response.UserReceivedAccount);
            Assert.NotNull(response.FundsAccount);
            Assert.True(response.Amount.Total > 0);
            Assert.True(response.Amount.Refund > 0);
            Assert.True(response.Amount.PayerTotal > 0);
            Assert.True(response.Amount.PayerRefund > 0);
        }
    }
}
