namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/all 接口的响应。</para>
    /// </summary>
    public class ChannelsECBrandAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置品牌商标中文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ch_name")]
                public string? ChineseName { get; set; }

                /// <summary>
                /// 获取或设置品牌商标英文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("en_name")]
                [System.Text.Json.Serialization.JsonPropertyName("en_name")]
                public string? EnglishName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brands")]
        [System.Text.Json.Serialization.JsonPropertyName("brands")]
        public Types.Brand[] BrandList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }
    }
}
