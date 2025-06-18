namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/delete 接口的请求。</para>
    /// </summary>
    public class CardPayGiftCardDeleteRequest : WechatApiRequest, IInferable<CardPayGiftCardDeleteRequest, CardPayGiftCardDeleteResponse>
    {
        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public int RuleId { get; set; }
    }
}
