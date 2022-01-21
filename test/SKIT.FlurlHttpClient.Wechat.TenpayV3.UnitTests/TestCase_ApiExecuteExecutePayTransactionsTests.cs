using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteExecutePayTransactionsTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /pay/transactions/app")]
        public async Task TestExecuteCreatePayTransactionApp()
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

        [Fact(DisplayName = "测试用例：调用 API [POST] /pay/transactions/jsapi")]
        public async Task TestExecuteCreatePayTransactionJsapi()
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

        [Fact(DisplayName = "测试用例：调用 API [POST] /pay/transactions/h5")]
        public async Task TestExecuteCreatePayTransactionH5()
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
        
        [Fact(DisplayName = "测试用例：调用 API [POST] /pay/transactions/native")]
        public async Task TestExecuteCreatePayTransactionNative()
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
        
        [Fact(DisplayName = "测试用例：调用 API [GET] /pay/transactions/id/{transaction_id}")]
        public async Task TestExecuteGetPayTransactionById()
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

        [Fact(DisplayName = "测试用例：调用 API [GET] /pay/transactions/out-trade-no/{out_trade_no}")]
        public async Task TestExecuteGetPayTransactionByOutTradeNumber()
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
        
        [Fact(DisplayName = "测试用例：调用 API [POST] /pay/transactions/out-trade-no/{out_trade_no}/close")]
        public async Task TestExecuteClosePayTransaction()
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
