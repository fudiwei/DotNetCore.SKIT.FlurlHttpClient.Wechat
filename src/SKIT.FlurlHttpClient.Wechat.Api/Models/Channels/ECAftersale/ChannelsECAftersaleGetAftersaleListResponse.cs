namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getaftersalelist 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetAftersaleListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置售后单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id_list")]
        public string[] AftersaleOrderIdList { get; set; } = default!;

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
