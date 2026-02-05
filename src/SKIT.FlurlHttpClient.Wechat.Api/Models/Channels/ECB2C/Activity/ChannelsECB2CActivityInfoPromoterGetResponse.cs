namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/b2c/activity/info/promoter/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECB2CActivityInfoPromoterGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Activity
            {
                public static class Types
                {
                    public class ActivityInfo
                    {
                        public static class Types
                        {
                            public class BasicInfo
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

                                        /// <summary>
                                        /// 获取或设置小店名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string Nickname { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置活动开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("activity_start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("activity_start_time")]
                                public long ActivityStartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置活动结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("activity_end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("activity_end_time")]
                                public long ActivityEndTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置店铺信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                                public Types.ShopInfo ShopInfo { get; set; } = default!;
                            }

                            public class PrizeInfo
                            {
                                public static class Types
                                {
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
                                        /// 获取或设置商品名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                        public string ProductName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品图片 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_img_url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_img_url")]
                                        public string ProductImageUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                        public long SKUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置 SKU 名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                                        public string SKUName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置售卖单价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                                        public int Price { get; set; }

                                        /// <summary>
                                        /// 获取或设置活动总库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("stock_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                                        public int Stock { get; set; }

                                        /// <summary>
                                        /// 获取或设置活动剩余库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("can_use_stock_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("can_use_stock_num")]
                                        public int StockCanUsed { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品信息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_info_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_info_list")]
                                public Types.ProductInfo[] ProductInfoList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置活动基础信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("basic_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("basic_info")]
                        public Types.BasicInfo BasicInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动礼物商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prize_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("prize_info")]
                        public Types.PrizeInfo PrizeInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public long ActivityId { get; set; }

                /// <summary>
                /// 获取或设置活动状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置活动信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("info")]
                [System.Text.Json.Serialization.JsonPropertyName("info")]
                public Types.ActivityInfo ActivityInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置活动信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity")]
        [System.Text.Json.Serialization.JsonPropertyName("activity")]
        public Types.Activity Activity { get; set; } = default!;
    }
}
