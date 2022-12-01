namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/order/search_normal_order 接口的响应。</para>
    /// </summary>
    public class UnionShopOrderSearchNormalOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class OrderDetail
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("orderId")]
                        [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outOrderId")]
                        [System.Text.Json.Serialization.JsonPropertyName("outOrderId")]
                        public string OutOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置微信支付交易单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transactionId")]
                        [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
                        public string? TransactionId { get; set; }

                        /// <summary>
                        /// 获取或设置支付时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("payTime")]
                        public long? PayTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("createTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("orderPrice")]
                        [System.Text.Json.Serialization.JsonPropertyName("orderPrice")]
                        public int OrderPrice { get; set; }

                        /// <summary>
                        /// 获取或设置运费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight")]
                        public int Freight { get; set; }

                        /// <summary>
                        /// 获取或设置优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discountedPrice")]
                        [System.Text.Json.Serialization.JsonPropertyName("discountedPrice")]
                        public int DiscountedPrice { get; set; }

                        /// <summary>
                        /// 获取或设置附加金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("additionalPrice")]
                        [System.Text.Json.Serialization.JsonPropertyName("additionalPrice")]
                        public int AdditionalPrice { get; set; }

                        /// <summary>
                        /// 获取或设置附加金额备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("additionalRemarks")]
                        [System.Text.Json.Serialization.JsonPropertyName("additionalRemarks")]
                        public string? additionalRemarks { get; set; }

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置订单状态最后更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statusUpdateTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("statusUpdateTime")]
                        public long? StatusUpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string? PagePath { get; set; }
                    }

                    public class Product
                    {
                        public static class Types
                        {
                            public class Promoter
                            {
                                /// <summary>
                                /// 获取或设置 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appId")]
                                [System.Text.Json.Serialization.JsonPropertyName("appId")]
                                public string AppId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nickName")]
                                [System.Text.Json.Serialization.JsonPropertyName("nickName")]
                                public string Nickname { get; set; } = default!;
                            }

                            public class SKUAttribute
                            {
                                /// <summary>
                                /// 获取或设置属性的 Key。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attrKey")]
                                [System.Text.Json.Serialization.JsonPropertyName("attrKey")]
                                public string Key { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置属性的值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attrValue")]
                                [System.Text.Json.Serialization.JsonPropertyName("attrValue")]
                                public string Value { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productId")]
                        [System.Text.Json.Serialization.JsonPropertyName("productId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outProductId")]
                        [System.Text.Json.Serialization.JsonPropertyName("outProductId")]
                        public string OutProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skuId")]
                        [System.Text.Json.Serialization.JsonPropertyName("skuId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outSkuId")]
                        [System.Text.Json.Serialization.JsonPropertyName("outSkuId")]
                        public string OutSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品头图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                        public string HeadImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品原价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("salePrice")]
                        [System.Text.Json.Serialization.JsonPropertyName("salePrice")]
                        public int SalePrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品现价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("realPrice")]
                        [System.Text.Json.Serialization.JsonPropertyName("realPrice")]
                        public int RealPrice { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skuAttrs")]
                        [System.Text.Json.Serialization.JsonPropertyName("skuAttrs")]
                        public Types.SKUAttribute[]? SKUAttributeList { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productCnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("productCnt")]
                        public int ProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置佣金比例（单位：万分之一）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                        public int CommissionRatio { get; set; }

                        /// <summary>
                        /// 获取或设置佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commissionValue")]
                        [System.Text.Json.Serialization.JsonPropertyName("commissionValue")]
                        public int CommissionValue { get; set; }

                        /// <summary>
                        /// 获取或设置分佣状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commissionStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("commissionStatus")]
                        public string CommissionStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分佣状态最后更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commissionStatusUpdateTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("commissionStatusUpdateTime")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? CommissionStatusUpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置推广员信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promoterInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("promoterInfo")]
                        public Types.Promoter? Promoter { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("orderInfo")]
                public Types.OrderDetail OrderDetail { get; set; }= default!;

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productList")]
                [System.Text.Json.Serialization.JsonPropertyName("productList")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderList")]
        [System.Text.Json.Serialization.JsonPropertyName("orderList")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
