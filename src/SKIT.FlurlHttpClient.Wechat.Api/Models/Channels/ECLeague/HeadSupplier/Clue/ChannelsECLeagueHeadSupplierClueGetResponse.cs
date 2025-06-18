namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/clue/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierClueGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CommissionClue
            {
                public static class Types
                {
                    public class ClueDetail
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
                                public string ShopAppId { get; set; } = default!;
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
                                /// 获取或设置缩略图 URL。
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
                                /// 获取或设置实际支付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_payment")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_payment")]
                                public int ActualPayment { get; set; }
                            }

                            public class OrderInfo
                            {
                                /// <summary>
                                /// 获取或设置订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }
                            }

                            public class SharerInfo
                            {
                                /// <summary>
                                /// 获取或设置推客 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sharer_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
                                public string SharerAppId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置推客的昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                public string Nickname { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置推客 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("opensharerid")]
                                [System.Text.Json.Serialization.JsonPropertyName("opensharerid")]
                                public string OpenSharerId { get; set; } = default!;
                            }

                            public class BuyerInfo
                            {
                                /// <summary>
                                /// 获取或设置买家的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("open_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                                public string OpenId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置买家的 UnionId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("union_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                                public string? UnionId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置小店信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                        public Types.ShopInfo ShopInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品信息。
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
                        /// 获取或设置分享者信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sharer_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sharer_info")]
                        public Types.SharerInfo SharerInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置买家信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_info")]
                        public Types.BuyerInfo BuyerInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置线索详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clue_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("clue_detail")]
                public Types.ClueDetail ClueDetail { get; set; } = default!;

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
            }
        }

        /// <summary>
        /// 获取或设置线索订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commssion_clue")]
        [System.Text.Json.Serialization.JsonPropertyName("commssion_clue")]
        public Types.CommissionClue CommissionClue { get; set; } = default!;
    }
}
