namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/cancel 接口的请求。</para>
    /// </summary>
    public class CancelPayScoreAcquiringBankServiceOrderRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户服务单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
