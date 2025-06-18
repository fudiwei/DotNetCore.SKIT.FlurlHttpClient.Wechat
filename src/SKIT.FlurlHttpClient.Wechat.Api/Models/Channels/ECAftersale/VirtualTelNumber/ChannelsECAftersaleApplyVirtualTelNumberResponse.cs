namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/applyvirtualtelnum 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleApplyVirtualTelNumberResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置虚拟号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_tel_number")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_number")]
        public string VirtualTelNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置主动兑换的虚拟号码过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("virtual_tel_expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("virtual_tel_expire_time")]
        public long VirtualTelNumberExpireTimestamp { get; set; }
    }
}
