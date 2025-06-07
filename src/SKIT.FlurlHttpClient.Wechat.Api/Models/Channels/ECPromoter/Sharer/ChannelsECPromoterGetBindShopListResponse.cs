namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_bind_shop_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetBindShopListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shop
            {
                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string ShopAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小店昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置小店头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_head_img")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_head_img")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                public long BindTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_list")]
        public Types.Shop[] ShopList { get; set; } = default!;

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
