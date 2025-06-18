namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-settlement/merchant-settle-rule-applications 接口的请求。</para>
    /// </summary>
    public class CreateMerchantSettlementSettleRuleApplymentRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置从业机构号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_id")]
        public string AcquiringBankId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string ChannelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结算规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_rule_id")]
        public int SettleRuleId { get; set; }
    }
}
