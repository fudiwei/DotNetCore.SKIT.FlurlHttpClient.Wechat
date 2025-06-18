namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBrandListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand : ChannelsECBrandGetResponse.Types.Brand
            {
            }
        }

        /// <summary>
        /// 获取或设置品牌列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brands")]
        [System.Text.Json.Serialization.JsonPropertyName("brands")]
        public Types.Brand[] BrandList { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
