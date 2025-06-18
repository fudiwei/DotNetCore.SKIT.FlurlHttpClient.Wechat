namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_feed_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetFeedListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Feed
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
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_img_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_img_url")]
                        public string ImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品最低价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_mini_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_mini_price")]
                        public int MinPrice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置短视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人平台 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                public string TalentAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置预估佣金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("predict_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("predict_commission_amount")]
                public int PredictCommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.ProductInfo ProductInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置短视频列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_list")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_list")]
        public Types.Feed[] FeedList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
