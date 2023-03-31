namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/acquiringbank/serviceorder 接口的响应。</para>
    /// </summary>
    public class GetPayScoreAcquiringBankServiceOrderByQueryIdResponse : GetPayScorePartnerServiceOrderByQueryIdResponse
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string ChannelId { get; set; } = default!;
    }
}
