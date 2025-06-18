namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/cancel 接口的请求。</para>
    /// </summary>
    public class CancelPayScoreAcquiringBankServiceOrderRequest : CancelPayScorePartnerServiceOrderRequest
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string ChannelId { get; set; } = string.Empty;
    }
}
