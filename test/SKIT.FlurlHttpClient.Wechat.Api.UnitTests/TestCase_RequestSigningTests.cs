using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public partial class TestCase_RequestSigningTests
    {
        [Fact(DisplayName = "测试用例：即时配送请求签名")]
        public async Task TestImmeDeliveryRequestSignature()
        {
            var httpClient = new HttpClient(new MockHttpMessageHandler(new HttpClientHandler()));
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "",
                AppSecret = "",
                ImmeDeliveryAppKey = "test_shop_id",
                ImmeDeliveryAppSecret = "test_app_secrect"
            }, httpClient);

            var request = new Models.CgibinExpressLocalBusinessTestUpdateOrderRequest()
            {
                ShopOrderId = "test_shop_order_id"
            };
            _ = await mockClient.ExecuteCgibinExpressLocalBusinessTestUpdateOrderAsync(request);

            Assert.Equal("a93d8d6bae9a9483c1b1d4e8670e7f6226ec94cb", request.DeliverySignature, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：虚拟支付请求签名")]
        public async Task TestVirtualPaymentRequestSignature()
        {
            var httpClient = new HttpClient(new MockHttpMessageHandler(new HttpClientHandler()));
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "wxtest",
                AppSecret = "",
                VirtualPaymentAppKey = "12345"
            }, httpClient);
            mockClient.Configure(settings =>
            {
                var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
                jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                jsonOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict;
                jsonOptions.WriteIndented = false;
                settings.JsonSerializer = new SystemTextJsonSerializer(jsonOptions);
            });

            var request = new Models.XPayQueryUserBalanceRequest()
            {
                OpenId = "xxx",
                Environment = 0,
                UserIp = "127.0.0.1",
                SessionKey = "9hAb/NEYUlkaMBEsmFgzig=="
            };
            _ = await mockClient.ExecuteXPayQueryUserBalanceAsync(request);

            Assert.Equal("e690cc22b6378ca9d70fe61727fabf65f0273d436813447816951989867a134c", request.Signature, ignoreCase: true);
            Assert.Equal("fb4703e6b7da545a7f43428f02f2a9fa42e895704c6319d01a0aa859cf63253c", request.PaySign, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：米大师 1.0 请求签名")]
        public async Task TestMidasRequestSignature()
        {
            var httpClient = new HttpClient(new MockHttpMessageHandler(new HttpClientHandler()));
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "wx1234567",
                AppSecret = "",
                MidasOfferId = "12345678",
                MidasAppKey = "zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u"
            }, httpClient);

            var request = new Models.CgibinMidasGetBalanceRequest()
            {
                OpenId = "odkx20ENSNa2w5y3g_qOkOvBNM1g",
                MidasZoneId = "1",
                Platform = "android",
                Timestamp = 1507530737
            };
            _ = await mockClient.ExecuteCgibinMidasGetBalanceAsync(request);

            Assert.Equal("1ad64e8dcb2ec1dc486b7fdf01f4a15159fc623dc3422470e51cf6870734726b", request.Signature, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：米大师 2.0 请求签名")]
        public async Task TestMidasV2RequestSignature()
        {
            var httpClient = new HttpClient(new MockHttpMessageHandler(new HttpClientHandler()));
            var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "wx1234567",
                AppSecret = "",
                MidasOfferIdV2 = "12345678",
                MidasAppKeyV2 = "12345"
            }, httpClient);
            mockClient.Configure(settings =>
            {
                var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
                jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                jsonOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict;
                jsonOptions.WriteIndented = false;
                settings.JsonSerializer = new SystemTextJsonSerializer(jsonOptions);
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
            _ = await mockClient.ExecuteWxaGameGetBalanceAsync(request);

            Assert.Equal("7ec6d737f118b0c898de39ef1b6b199c48290e699495364fe9d069597a7da125", request.Signature, ignoreCase: true);
            Assert.Equal("5fc5460b23b2589efb8adbc2cf08d7a9cd8892b33e084249a26455b7880741a8", request.PaySign, ignoreCase: true);
        }
    }

    partial class TestCase_RequestSigningTests
    {
        public class MockHttpClient : HttpClient
        {
            public MockHttpClient()
                : base(new MockHttpMessageHandler(new HttpClientHandler()))
            {
            }
        }

        public class MockHttpMessageHandler : DelegatingHandler
        {
            public MockHttpMessageHandler(HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                string mockResponseContent = "{\"errcode\":0}";
                byte[] mockResponseBytes = Encoding.UTF8.GetBytes(mockResponseContent);
                var resp = new HttpResponseMessage
                {
                    RequestMessage = request,
                    StatusCode = HttpStatusCode.NoContent,
                    Content = new ByteArrayContent(mockResponseBytes),
                };
                resp.Headers.TryAddWithoutValidation("Content-Length", mockResponseBytes.Length.ToString());
                return Task.FromResult(resp);
            }
        }
    }
}
