using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteMarketingFavorTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/favor/coupon-stocks")]
        public async Task TestExecuteCreateMarketingFavorStock()
        {
            var request = new Models.CreateMarketingFavorStockRequest()
            {
                StockName = "FAKE_STOCK",
                StockType = "NORMAL",
                OutRequestNumber = "TEST_ORN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AvailableBeginTime = DateTime.Today.AddDays(1),
                AvailableEndTime = DateTime.Today.AddDays(31),
                StockUseRule = new Models.CreateMarketingFavorStockRequest.Types.StockUseRule()
                {
                    MaxCoupons = 1,
                    MaxAmount = 1,
                    MaxCouponsPerUser = 1
                },
                CouponUseRule = new Models.CreateMarketingFavorStockRequest.Types.CouponUseRule()
                {
                    NormalCoupon = new Models.CreateMarketingFavorStockRequest.Types.CouponUseRule.Types.NormalCoupon()
                    {
                        CouponAmount = 1,
                        TransactionMinimum = 1
                    },
                    AvailableMerchantIdList = new List<string>() { TestConfigs.WechatMerchantId }
                },
                IsNoCash = false
            };
            var response = await TestClients.InstanceUseRSA.ExecuteCreateMarketingFavorStockAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/favor/stocks/{stock_id}/start")]
        public async Task TestExecuteStartMarketingFavorStock()
        {
            var request = new Models.StartMarketingFavorStockRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteStartMarketingFavorStockAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/favor/stocks/{stock_id}/pause")]
        public async Task TestExecutePauseMarketingFavorStock()
        {
            var request = new Models.PauseMarketingFavorStockRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecutePauseMarketingFavorStockAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/favor/stocks/{stock_id}/restart")]
        public async Task TestExecuteRestartMarketingFavorStock()
        {
            var request = new Models.RestartMarketingFavorStockRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteRestartMarketingFavorStockAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/favor/stocks/{stock_id}")]
        public async Task TestExecuteGetMarketingFavorStockByStockId()
        {
            var request = new Models.GetMarketingFavorStockByStockIdRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteGetMarketingFavorStockByStockIdAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/favor/stocks")]
        public async Task TestExecuteQueryMarketingFavorStocks()
        {
            var request = new Models.QueryMarketingFavorStocksRequest();
            var response = await TestClients.InstanceUseRSA.ExecuteQueryMarketingFavorStocksAsync(request);

            Assert.True(response.IsSuccessful());

            if (response.StockList.Any())
            {
                Assert.NotNull(response.StockList.First().StockId);
                Assert.NotNull(response.StockList.First().StockName);
                Assert.NotNull(response.StockList.First().StockType);
                Assert.NotNull(response.StockList.First().StockCreatorMerchantId);
                Assert.NotNull(response.StockList.First().StockUseRule);
                Assert.NotNull(response.StockList.First().Status);
            }
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/favor/stocks/{stock_id}/merchants")]
        public async Task TestExecuteQueryMarketingFavorStockMerchants()
        {
            var request = new Models.QueryMarketingFavorStockMerchantsRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteQueryMarketingFavorStockMerchantsAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
            Assert.NotNull(response.MerchantIdList);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/favor/stocks/{stock_id}/items")]
        public async Task TestExecuteQueryMarketingFavorStockItems()
        {
            var request = new Models.QueryMarketingFavorStockItemsRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteQueryMarketingFavorStockItemsAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
            Assert.NotNull(response.Items);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/favor/callbacks")]
        public async Task TestExecuteUpdateMarketingFavorCallback()
        {
            var request = new Models.UpdateMarketingFavorCallbackRequest()
            {
                NotifyUrl = "https://FAKE_URL",
                Switch = false
            };
            var response = await TestClients.InstanceUseRSA.ExecuteUpdateMarketingFavorCallbackAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.NotifyUrl);
        }
    }
}
