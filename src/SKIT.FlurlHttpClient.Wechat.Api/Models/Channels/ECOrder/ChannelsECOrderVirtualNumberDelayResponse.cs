namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/virtualnumber/delay 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderVirtualNumberDelayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置虚拟号码过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiration")]
        [System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public long ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置可延期次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_extend_num")]
        [System.Text.Json.Serialization.JsonPropertyName("available_extend_num")]
        public int AvailableDelayTimes { get; set; }
    }
}
