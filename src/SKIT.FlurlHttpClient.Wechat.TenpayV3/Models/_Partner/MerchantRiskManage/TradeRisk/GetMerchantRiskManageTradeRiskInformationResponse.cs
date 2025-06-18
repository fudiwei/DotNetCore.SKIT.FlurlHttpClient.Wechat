namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-risk-manage/trade-risk-information 接口的响应。</para>
    /// </summary>
    public class GetMerchantRiskManageTradeRiskInformationResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置风险系数值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_score")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_score")]
        public int RiskScore { get; set; }

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
    }
}
