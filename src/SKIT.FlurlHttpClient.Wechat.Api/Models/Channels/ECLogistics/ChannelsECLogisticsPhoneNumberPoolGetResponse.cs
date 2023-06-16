namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/phonenumberpool/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsPhoneNumberPoolGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置虚拟号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phonenumbers")]
        [System.Text.Json.Serialization.JsonPropertyName("phonenumbers")]
        public string[] VirtualPhoneNumberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

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
