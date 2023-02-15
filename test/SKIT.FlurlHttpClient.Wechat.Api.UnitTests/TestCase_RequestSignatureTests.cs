using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_RequestSignatureTests
    {
        [Fact(DisplayName = "测试用例：即时配送请求签名")]
        public async Task TestImmeDeliveryRequestSignature()
        {
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
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
            var response = await mockClient.ExecuteCgibinExpressLocalBusinessTestUpdateOrderAsync(request); // 这里不关心响应结果，只为获得预处理请求

            Assert.Equal("a93d8d6bae9a9483c1b1d4e8670e7f6226ec94cb", request.DeliverySignature, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：米大师虚拟支付 1.0 请求签名")]
        public async Task TestMidasRequestSignature()
        {
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "wx1234567",
                AppSecret = "",
                MidasOfferId = "12345678",
                MidasAppKey = "zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u"
            });

            var request = new Models.CgibinMidasGetBalanceRequest()
            {
                OpenId = "odkx20ENSNa2w5y3g_qOkOvBNM1g",
                MidasZoneId = "1",
                Platform = "android",
                Timestamp = 1507530737
            };
            var response = await mockClient.ExecuteCgibinMidasGetBalanceAsync(request); // 这里不关心响应结果，只为获得预处理请求

            Assert.Equal("1ad64e8dcb2ec1dc486b7fdf01f4a15159fc623dc3422470e51cf6870734726b", request.Signature, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：米大师虚拟支付 2.0 请求签名")]
        public async Task TestMidasRequestSignatureV2()
        {
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "wx1234567",
                AppSecret = "",
                MidasOfferIdV2 = "12345678",
                MidasAppKeyV2 = "12345"
            });
            mockClient.Configure(settings =>
            {
                var jsonOptions = FlurlSystemTextJsonSerializer.GetDefaultSerializerOptions();
                jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                jsonOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict;
                jsonOptions.WriteIndented = false;
                settings.JsonSerializer = new FlurlSystemTextJsonSerializer(jsonOptions);
            });

            var request = new Models.WxaGameGetBalanceRequest()
            {
                OpenId = "oUrsfxxxxxxxxxx",
                OfferId = "12345678",
                ZoneId = "1",
                Environment = 0,
                Timestamp = 1668136271,
                SessionKey = "9hAb/NEYUlkaMBEsmFgzig=="
            };
            var response = await mockClient.ExecuteWxaGameGetBalanceAsync(request); // 这里不关心响应结果，只为获得预处理请求

            Assert.Equal("7ec6d737f118b0c898de39ef1b6b199c48290e699495364fe9d069597a7da125", request.Signature, ignoreCase: true);
            Assert.Equal("5fc5460b23b2589efb8adbc2cf08d7a9cd8892b33e084249a26455b7880741a8", request.PaySign, ignoreCase: true);
        }
    }
}
