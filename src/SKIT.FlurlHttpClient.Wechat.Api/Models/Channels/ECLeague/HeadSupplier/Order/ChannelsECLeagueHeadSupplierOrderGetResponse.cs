namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/order/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CommssionOrder
            {
                public static class Types
                {
                    public class OrderDetail
                    {
                        public static class Types
                        {
                            public class ShopInfo
                            {
                                /// <summary>
                                /// 获取或设置小店 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                public string AppId { get; set; } = default!;
                            }

                            public class ProductInfo
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                                public string ThumbnailUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置可分佣金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_payment")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_payment")]
                                public int ActualPayAmount { get; set; }
                            }

                            public class OrderInfo
                            {
                                /// <summary>
                                /// 获取或设置订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                                public int Status { get; set; }
                            }

                            public class CommissionInfo
                            {
                                public static class Types
                                {
                                    public class FinderInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置达人昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string Nickname { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置佣金费率（单位：万分数）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                                        public int CommissionRatio { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        public int CommissionAmount { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置达人信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_info")]
                                public Types.FinderInfo FinderInfo { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置服务费率（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
                                public int ServiceRatio { get; set; }

                                /// <summary>
                                /// 获取或设置服务费用（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_amount")]
                                public int ServiceAmount { get; set; }

                                /// <summary>
                                /// 获取或设置结算时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("profit_sharding_suc_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("profit_sharding_suc_time")]
                                public long ProfitShardingSuccessTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置小店商家信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                        public Types.ShopInfo ShopInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                        public Types.ProductInfo ProductInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
                        public Types.OrderInfo OrderInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分佣信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                        public Types.CommissionInfo CommissionInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置佣金单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public Types.OrderDetail OrderDetail { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置佣金单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commssion_order")]
        [System.Text.Json.Serialization.JsonPropertyName("commssion_order")]
        public Types.CommssionOrder CommssionOrder { get; set; } = default!;
    }
}
