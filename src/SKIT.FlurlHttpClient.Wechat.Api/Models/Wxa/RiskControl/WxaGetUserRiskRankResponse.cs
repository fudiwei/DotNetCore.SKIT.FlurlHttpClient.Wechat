namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getuserriskrank 接口的响应。</para>
    /// </summary>
    public class WxaGetUserRiskRankResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置唯一请求标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unoin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("unoin_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户风险等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_rank")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_rank")]
        public int RiskRank { get; set; }
    }
}
