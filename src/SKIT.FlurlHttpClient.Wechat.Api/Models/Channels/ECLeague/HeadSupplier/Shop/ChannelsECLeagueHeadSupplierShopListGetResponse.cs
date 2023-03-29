namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/shop/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierShopListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shop
            {
                public static class Types
                {
                    public class BaseInfo
                    {
                        /// <summary>
                        /// 获取或设置小店 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小店昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小店头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headimg_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("headimg_url")]
                        public string HeadImageUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置合作状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置小店基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo BaseInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置合作小店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_list")]
        public Types.Shop[] ShopList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
