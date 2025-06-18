namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-risk-manage/trade-risk-result 接口的响应。</para>
    /// </summary>
    public class CreateMerchantRiskManageTradeRiskResultResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置从业机构号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_id")]
        public string? AcquiringBankId { get; set; }

        /// <summary>
        /// 获取或设置渠道号。
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
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置风险类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_type")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_type")]
        public string? RiskType { get; set; }

        /// <summary>
        /// 获取或设置处置手段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("punish_type")]
        [System.Text.Json.Serialization.JsonPropertyName("punish_type")]
        public string? PunishType { get; set; }

        /// <summary>
        /// 获取或设置处置手段描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("punish_description")]
        [System.Text.Json.Serialization.JsonPropertyName("punish_description")]
        public string? PunishDescription { get; set; }

        /// <summary>
        /// 获取或设置处置手段补充。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_punish_type")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_punish_type")]
        public string? AdditionalPunishType { get; set; }
    }
}
