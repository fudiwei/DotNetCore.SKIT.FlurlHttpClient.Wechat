namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_bind_shop_promoter_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetBindShopPromoterListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置关联账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
                public string PromoterId { get; set; } = default!;

                /// <summary>
                /// 获取或设置关联账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_type")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_type")]
                public int PromoterType { get; set; }

                /// <summary>
                /// 获取或设置关联账号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_name")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_name")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置关联账号头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar_image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar_image_url")]
                public string HeadImageUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置关联账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_list")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_list")]
        public Types.Promoter[] PromoterList { get; set; } = default!;

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
