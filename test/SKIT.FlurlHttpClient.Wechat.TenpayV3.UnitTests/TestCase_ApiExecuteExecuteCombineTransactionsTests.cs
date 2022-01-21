using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteExecuteCombineTransactionsTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /combine-transactions/app")]
        public async Task TestExecuteCreateCombineTransactionApp()
        {
            var request = new Models.CreateCombineTransactionAppRequest()
            {
                CombineAppId = TestConfigs.WechatAppId,
                CombineOutTradeNumber = "TEST_COTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                SubOrderList = new Models.CreateCombineTransactionAppRequest.Types.SubOrder[]
                {
                    new Models.CreateCombineTransactionAppRequest.Types.SubOrder()
                    {
                        OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                        Description = "FAKE_DESCRIPTION",
                        Amount = new Models.CreateCombineTransactionAppRequest.Types.SubOrder.Types.Amount()
                        {
                            Total = 1
                        }
                    }
                },
                NotifyUrl = "http://127.0.0.1"
            };
            var response = await TestClients.Instance.ExecuteCreateCombineTransactionAppAsync(request);

            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /combine-transactions/jsapi")]
        public async Task TestExecuteCreateCombineTransactionJsapi()
        {
            var request = new Models.CreateCombineTransactionJsapiRequest()
            {
                CombineAppId = TestConfigs.WechatAppId,
                CombineOutTradeNumber = "TEST_COTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                SubOrderList = new Models.CreateCombineTransactionJsapiRequest.Types.SubOrder[]
                {
                    new Models.CreateCombineTransactionJsapiRequest.Types.SubOrder()
                    {
                        OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff") + "1",
                        Description = "FAKE_DESCRIPTION",
                        Amount = new Models.CreateCombineTransactionJsapiRequest.Types.SubOrder.Types.Amount()
                        {
                            Total = 1
                        }
                    },
                    new Models.CreateCombineTransactionJsapiRequest.Types.SubOrder()
                    {
                        OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff") + "2",
                        Description = "FAKE_DESCRIPTION",
                        Amount = new Models.CreateCombineTransactionJsapiRequest.Types.SubOrder.Types.Amount()
                        {
                            Total = 1
                        }
                    }
                },
                CombinePayer = new Models.CreateCombineTransactionJsapiRequest.Types.Payer()
                { 
                    OpenId = TestConfigs.WechatOpenId
                },
                NotifyUrl = "http://127.0.0.1"
            };
            var response = await TestClients.Instance.ExecuteCreateCombineTransactionJsapiAsync(request);

            Assert.NotNull(response.PrepayId);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /combine-transactions/h5")]
        public async Task TestExecuteCreateCombineTransactionH5()
        {
            var request = new Models.CreateCombineTransactionH5Request()
            {
                CombineAppId = TestConfigs.WechatAppId,
                CombineOutTradeNumber = "TEST_COTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                SubOrderList = new Models.CreateCombineTransactionH5Request.Types.SubOrder[]
                {
                    new Models.CreateCombineTransactionH5Request.Types.SubOrder()
                    {
                        OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                        Description = "FAKE_DESCRIPTION",
                        Amount = new Models.CreateCombineTransactionH5Request.Types.SubOrder.Types.Amount()
                        {
                            Total = 1
                        }
                    }
                },
                NotifyUrl = "http://127.0.0.1"
            };
            var response = await TestClients.Instance.ExecuteCreateCombineTransactionH5Async(request);

            Assert.NotNull(response.H5Url);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /combine-transactions/native")]
        public async Task TestExecuteCreateCombineTransactionNative()
        {
            var request = new Models.CreateCombineTransactionNativeRequest()
            {
                CombineAppId = TestConfigs.WechatAppId,
                CombineOutTradeNumber = "TEST_COTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                SubOrderList = new Models.CreateCombineTransactionNativeRequest.Types.SubOrder[]
                {
                    new Models.CreateCombineTransactionNativeRequest.Types.SubOrder()
                    {
                        OutTradeNumber = "TEST_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                        Description = "FAKE_DESCRIPTION",
                        Amount = new Models.CreateCombineTransactionNativeRequest.Types.SubOrder.Types.Amount()
                        {
                            Total = 1
                        }
                    }
                },
                NotifyUrl = "http://127.0.0.1"
            };
            var response = await TestClients.Instance.ExecuteCreateCombineTransactionNativeAsync(request);

            Assert.NotNull(response.QrcodeUrl);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /combine-transactions/out-trade-no/{combine_out_trade_no}")]
        public async Task TestExecuteGetCombineTransactionByCombineOutTradeNumber()
        {
            var request = new Models.GetCombineTransactionByCombineOutTradeNumberRequest()
            {
                CombineOutTradeNumber = "FAKE_OUTTRADENO"
            };
            var response = await TestClients.Instance.ExecuteGetCombineTransactionByCombineOutTradeNumberAsync(request);

            Assert.NotNull(response.CombineAppId);
            Assert.NotNull(response.CombineMerchantId);
            Assert.NotNull(response.CombineOutTradeNumber);
            Assert.NotEmpty(response.SubOrderList);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /combine-transactions/out-trade-no/{combine_out_trade_no}/close")]
        public async Task TestExecuteCloseCombineTransaction()
        {
            var request = new Models.CloseCombineTransactionRequest()
            {
                CombineAppId = TestConfigs.WechatAppId,
                CombineOutTradeNumber = "FAKE_OUTTRADENO",
                SubOrderList = new Models.CloseCombineTransactionRequest.Types.SubOrder[]
                { 
                    new Models.CloseCombineTransactionRequest.Types.SubOrder()
                    {
                        OutTradeNumber = "FAKE_OUTTRADENO"
                    }
                }
            };
            var response = await TestClients.Instance.ExecuteCloseCombineTransactionAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
