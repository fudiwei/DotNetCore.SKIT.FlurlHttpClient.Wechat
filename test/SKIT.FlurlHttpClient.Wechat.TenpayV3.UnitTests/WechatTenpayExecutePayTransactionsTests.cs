using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayExecutePayTransactionsTests
    {
        [Fact(DisplayName = "[POST] /pay/transactions/app")]
        public async Task CreatePayTransactionAppTest()
        {
            var request = new Models.CreatePayTransactionAppRequest()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = TestConfigs.WechatAppId,
                Description = "FAKE_DESCRIPTION",
                NotifyUrl = "http://127.0.0.1",
                Amount = new Models.CreatePayTransactionAppRequest.Types.Amount()
                {
                    Total = 1
                }
            };
            var response = await TestClients.Instance.ExecuteCreatePayTransactionAppAsync(request);

            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "[POST] /pay/transactions/jsapi")]
        public async Task CreatePayTransactionJsapiTest()
        {
            var request = new Models.CreatePayTransactionJsapiRequest()
            {
                OutTradeNumber = "TEST" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = TestConfigs.WechatAppId,
                Description = "FAKE_DESCRIPTION",
                ExpireTime = DateTimeOffset.Now.AddMinutes(30),
                NotifyUrl = "http://127.0.0.1",
                Amount = new Models.CreatePayTransactionJsapiRequest.Types.Amount()
                {
                    Total = 1
                },
                Payer = new Models.CreatePayTransactionJsapiRequest.Types.Payer()
                {
                    OpenId = TestConfigs.WechatOpenId
                }
            };
            var response = await TestClients.Instance.ExecuteCreatePayTransactionJsapiAsync(request);

            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "[POST] /pay/transactions/h5")]
        public async Task CreatePayTransactionH5Test()
        {
            var request = new Models.CreatePayTransactionH5Request()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = TestConfigs.WechatAppId,
                Description = "FAKE_DESCRIPTION",
                NotifyUrl = "http://127.0.0.1",
                Amount = new Models.CreatePayTransactionH5Request.Types.Amount()
                {
                    Total = 1
                }
            };
            var response = await TestClients.Instance.ExecuteCreatePayTransactionH5Async(request);

            Assert.NotNull(response.H5Url);
        }
        
        [Fact(DisplayName = "[POST] /pay/transactions/native")]
        public async Task CreatePayTransactionNativeTest()
        {
            var request = new Models.CreatePayTransactionNativeRequest()
            {
                OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = TestConfigs.WechatAppId,
                Description = "FAKE_DESCRIPTION",
                NotifyUrl = "http://127.0.0.1",
                Amount = new Models.CreatePayTransactionNativeRequest.Types.Amount()
                {
                    Total = 1
                }
            };
            var response = await TestClients.Instance.ExecuteCreatePayTransactionNativeAsync(request);

            Assert.NotNull(response.QrcodeUrl);
        }
        
        [Fact(DisplayName = "[GET] /pay/transactions/id/{transaction_id}")]
        public async Task GetPayTransactionByIdTest()
        {
            var request = new Models.GetPayTransactionByIdRequest()
            {
                TransactionId = "FAKE_TRANSACTIONID"
            };
            var response = await TestClients.Instance.ExecuteGetPayTransactionByIdAsync(request);

            Assert.NotNull(response.AppId);
            Assert.NotNull(response.MerchantId);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.TransactionId);
            Assert.NotNull(response.TradeState);
            Assert.NotNull(response.TradeStateDescription);
            Assert.True(response.Amount.Total > 0);
        }

        [Fact(DisplayName = "[GET] /pay/transactions/out-trade-no/{out_trade_no}")]
        public async Task GetPayTransactionByOutTradeNumberTest()
        {
            var request = new Models.GetPayTransactionByOutTradeNumberRequest()
            {
                OutTradeNumber = "FAKE_OUTTRADENO"
            };
            var response = await TestClients.Instance.ExecuteGetPayTransactionByOutTradeNumberAsync(request);

            Assert.NotNull(response.AppId);
            Assert.NotNull(response.MerchantId);
            Assert.NotNull(response.OutTradeNumber);
            Assert.NotNull(response.TradeState);
            Assert.NotNull(response.TradeStateDescription);
            Assert.True(response.Amount.Total > 0);
        }
        
        [Fact(DisplayName = "[POST] /pay/transactions/out-trade-no/{out_trade_no}/close")]
        public async Task ClosePayTransactionTest()
        {
            var request = new Models.ClosePayTransactionRequest()
            {
                OutTradeNumber = "TEST20210419193742518"
            };
            var response = await TestClients.Instance.ExecuteClosePayTransactionAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
