﻿using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_DeliveryRequestSignatureTests
    {
        [Fact(DisplayName = "测试用例：即时配送请求签名")]
        public async Task TestDeliveryRequestSignature()
        {
            var client = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "",
                AppSecret = "",
                ImmeDeliveryAppKey = "test_shop_id",
                ImmeDeliveryAppSecret = "test_app_secrect"
            });
            var request = new Models.CgibinExpressLocalBusinessTestUpdateOrderRequest()
            {
                ShopOrderId = "test_shop_order_id"
            };
            var response = await client.ExecuteCgibinExpressLocalBusinessTestUpdateOrderAsync(request);

            Assert.Equal("a93d8d6bae9a9483c1b1d4e8670e7f6226ec94cb", request.DeliverySignature, ignoreCase: true);
        }
    }
}
