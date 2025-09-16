using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public partial class TestCase_RequestSigningTests
    {
        [Fact(DisplayName = "测试用例：收银台收款工具接口请求签名")]
        public async Task TestPayToolRequestSignature()
        {
            var httpClient = new HttpClient(new MockHttpMessageHandler(new HttpClientHandler()));
            var mockClient = new WechatWorkClient(new WechatWorkClientOptions()
            {
                PayToolApiSecret = "at23pxnPBNQY3JiA8N5U1gabiQqxZwqH_Gihg7a_wrULmlOPVP-iiRjv9JWYPrDk"
            }, new MockHttpClient());

            // 简单数据结构
            {
                var request = new Models.CgibinPayToolCloseOrderRequest()
                {
                    OrderId = "T0Rkc2g3dWlQNzFLNTRXMDJBV25BNi95OVZZbjBPOE11N2FCWkc0STJRdz0=",
                    NonceString = "129031823",
                    Timestamp = 1548302135
                };
                _ = await mockClient.ExecuteCgibinPayToolCloseOrderAsync(request);

                Assert.Equal("jzjAGcoLbquKfNVlpqzBJDSdUASP8J7PebdFB6CUnRg=", request.Signature);
            }

            // 复杂数据结构
            {
                var request = new Models.CgibinPayToolOpenOrderRequest()
                {
                    BusinessType = 1,
                    CustomCorpId = "wx979abee1572365f9",
                    PayType = 1,
                    BandReceiptMediaId = "MEDIA_ID_XXX",
                    CreatorUserId = "CREATOR",
                    Product = new Models.CgibinPayToolOpenOrderRequest.Types.Product()
                    {
                        ThirdPartyApp = new Models.CgibinPayToolOpenOrderRequest.Types.Product.Types.ThirdPartyApp()
                        {
                            OrderType = 0,
                            BuyInfoList = new List<Models.CgibinPayToolOpenOrderRequest.Types.Product.Types.ThirdPartyApp.Types.BuyInfo>()
                            {
                                new Models.CgibinPayToolOpenOrderRequest.Types.Product.Types.ThirdPartyApp.Types.BuyInfo()
                                {
                                    SuiteId = "wx63bea8582b858ee7",
                                    AppId = 1,
                                    EditionId = "sp7fd5170a8e807a44",
                                    DurationDays = 1,
                                    TakeEffectDateString = "20221220",
                                    UserCount = 10,
                                    DiscountInfo = new Models.CgibinPayToolOpenOrderRequest.Types.Product.Types.ThirdPartyApp.Types.BuyInfo.Types.DiscountInfo()
                                    {
                                        DiscountType = 2,
                                        DiscountAmount = 0,
                                        DiscountRatio = 75,
                                        DiscountRemarks = "老客户优惠"
                                    }
                                },
                                new Models.CgibinPayToolOpenOrderRequest.Types.Product.Types.ThirdPartyApp.Types.BuyInfo()
                                {
                                    SuiteId = "wx46b0217691d307f7",
                                    AppId = 1,
                                    EditionId = "spb5625fc505870d09",
                                    DurationDays = 1,
                                    UserCount = 10,
                                }
                            },
                            IsNotifyCustomCorp = true
                        }
                    },
                    NonceString = "129031823",
                    Timestamp = 1548302135
                };
                _ = await mockClient.ExecuteCgibinPayToolOpenOrderAsync(request);

                Assert.Equal("5c6ZV2YFUWSA+2t4i92wUi4INQPYj3m6DArzLXkwxxk=", request.Signature);
            }
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
