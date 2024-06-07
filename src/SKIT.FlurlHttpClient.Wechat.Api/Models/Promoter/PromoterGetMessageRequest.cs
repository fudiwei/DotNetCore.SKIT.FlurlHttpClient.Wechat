namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getmsg 接口的请求。</para>
    /// </summary>
    public class PromoterGetMessageRequest : PublisherStatSettlementRequest, IInferable<PromoterGetMessageRequest, PromoterGetMessageResponse>
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = string.Empty;
    }
}
