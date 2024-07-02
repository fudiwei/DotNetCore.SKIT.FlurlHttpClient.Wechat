namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/permissions/assess-user-risk-level 接口的响应。</para>
    /// </summary>
    public class AssessPayScorePermissionsUserRiskLevelResponse : GetPayScorePermissionsByAuthorizationCodeResponse
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置用户标签。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_label")]
        [System.Text.Json.Serialization.JsonPropertyName("user_label")]
        public string? UserLabel { get; set; }

        /// <summary>
        /// 获取或设置用户分层。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_risk_level")]
        [System.Text.Json.Serialization.JsonPropertyName("user_risk_level")]
        public int? UserRiskLevel { get; set; }

        /// <summary>
        /// 获取或设置分层版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_level_version")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_level_version")]
        public int? RiskLevelVersion { get; set; }
    }
}
