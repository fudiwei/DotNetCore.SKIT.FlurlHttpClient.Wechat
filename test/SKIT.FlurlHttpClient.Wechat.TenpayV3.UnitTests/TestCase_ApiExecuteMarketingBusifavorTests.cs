using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteMarketingBusifavorTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/busifavor/stocks")]
        public async Task TestExecuteCreateMarketingBusifavorStock()
        {
            var request = new Models.CreateMarketingBusifavorStockRequest()
            {
                StockName = "FAKE_STOCK",
                StockType = "NORMAL",
                OutRequestNumber = "TEST_ORN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                StockSendRule = new Models.CreateMarketingBusifavorStockRequest.Types.StockSendRule()
                {
                    MaxCoupons = 1,
                    MaxCouponsPerUser = 1
                },
                CouponUseRule = new Models.CreateMarketingBusifavorStockRequest.Types.CouponUseRule()
                {
                    CouponAvailableTime = new Models.CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.CouponAvailableTime()
                    {
                        AvailableBeginTime = DateTime.Today.AddDays(1),
                        AvailableEndTime = DateTime.Today.AddDays(31)
                    },
                    NormalCoupon = new Models.CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.NormalCoupon()
                    {
                        DiscountAmount = 1,
                        TransactionMinimum = 1
                    },
                    UseMethod = "OFF_LINE"
                },
                GoodsName = "FAKE_GOODS",
                CouponCodeMode = "WECHATPAY_MODE"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteCreateMarketingBusifavorStockAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/busifavor/stocks/{stock_id}")]
        public async Task TestExecuteGetMarketingBusifavorStockByStockId()
        {
            var request = new Models.GetMarketingBusifavorStockByStockIdRequest()
            {
                StockId = "FAKE_STOCKID"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteGetMarketingBusifavorStockByStockIdAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.StockId);
            Assert.NotNull(response.StockName);
            Assert.NotNull(response.StockType);
            Assert.NotNull(response.StockState);
            Assert.NotNull(response.StockSendRule);
            Assert.NotNull(response.CouponUseRule);
            Assert.NotNull(response.CouponCodeMode);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/busifavor/users/{openid}/coupons")]
        public async Task TestExecuteQueryMarketingBusifavorUserCoupons()
        {
            var request = new Models.QueryMarketingBusifavorUserCouponsRequest()
            {
                AppId = TestConfigs.WechatAppId,
                OpenId = TestConfigs.WechatOpenId,
                BelongMerchantId = TestConfigs.WechatMerchantId
            };
            var response = await TestClients.InstanceUseRSA.ExecuteQueryMarketingBusifavorUserCouponsAsync(request);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/busifavor/callbacks")]
        public async Task TestExecuteUpdateMarketingBusifavorCallback()
        {
            var request = new Models.UpdateMarketingBusifavorCallbackRequest()
            {
                NotifyUrl = "https://FAKE_URL"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteUpdateMarketingBusifavorCallbackAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.NotifyUrl);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/busifavor/callbacks")]
        public async Task TestExecuteGetMarketingBusifavorCallback()
        {
            var request = new Models.GetMarketingBusifavorCallbackRequest();
            var response = await TestClients.InstanceUseRSA.ExecuteGetMarketingBusifavorCallbackAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.NotifyUrl);
        }
    }
}
