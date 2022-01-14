namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/promoter/list 接口的响应。</para>
    /// </summary>
    public class ShopPromoterListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置推广员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
                public string PromoterId { get; set; } = default!;

                /// <summary>
                /// 获取或设置推广员视频号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_nickname")]
                public string FinderNickname { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置推广员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoters")]
        [System.Text.Json.Serialization.JsonPropertyName("promoters")]
        public Types.Promoter[] PromoterList { get; set; } = default!;

        /// <summary>
        /// 获取或设置推广员总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
