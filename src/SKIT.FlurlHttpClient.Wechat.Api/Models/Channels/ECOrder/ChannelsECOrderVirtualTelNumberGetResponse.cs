namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/virtualtelnumber/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderVirtualTelNumberGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置虚拟号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_tel_number")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_number")]
        public string VirtualTelNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置虚拟号码过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_tel_expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_expire_time")]
        public long VirtualTelNumberExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置兑换虚拟号码次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_virtual_tel_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("get_virtual_tel_cnt")]
        public int GetVirtualTelNumberCount { get; set; }
    }
}
