namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_talent_biz_article_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetTalentMpArticleListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Article
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
                        /// 获取或设置预估佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("predict_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("predict_commission_amount")]
                        public int PredictCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品最低价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_mini_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_mini_price")]
                        public int MinPrice { get; set; }
                    }

                    public class ArticleInfo
                    {
                        /// <summary>
                        /// 获取或设置文章标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("article_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("article_title")]
                        public string ArticleTitle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置封面图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover_image")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover_image")]
                        public string CoverImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文章 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("article_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("article_url")]
                        public string ArticleUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文章推广参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promoter_share_link")]
                        [System.Text.Json.Serialization.JsonPropertyName("promoter_share_link")]
                        public string PromoterShareLink { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info_list")]
                public Types.ProductInfo[] ProductInfoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置文章信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("article_info")]
                [System.Text.Json.Serialization.JsonPropertyName("article_info")]
                public Types.ArticleInfo ArticleInfo { get; set; } = default!;

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
        /// 获取或设置文章列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_list")]
        [System.Text.Json.Serialization.JsonPropertyName("article_list")]
        public Types.Article[] ArticleList { get; set; } = default!;

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
