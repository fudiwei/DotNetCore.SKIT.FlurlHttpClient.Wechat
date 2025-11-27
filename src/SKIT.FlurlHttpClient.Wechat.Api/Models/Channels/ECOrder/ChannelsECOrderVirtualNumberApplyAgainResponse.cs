namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/virtualnumber/applyagain 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderVirtualNumberApplyAgainResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置虚拟号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_number")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_number")]
        public string VirtualNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置分机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extension")]
        [System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? ExtensionNumber { get; set; }

        /// <summary>
        /// 获取或设置剩余申请次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_quota")]
        public int ApplyQuota { get; set; }
    }
}
