namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/virtualnumber/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsVirtualNumberGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置打码的真实号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("masked_real_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("masked_real_phone")]
        public string MaskedPhoneNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置虚拟号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("main_phone")]
        public string VirtualPhoneNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置完整虚拟号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_phone")]
        public string FullVirtualPhoneNumber { get; set; } = default!;
    }
}
