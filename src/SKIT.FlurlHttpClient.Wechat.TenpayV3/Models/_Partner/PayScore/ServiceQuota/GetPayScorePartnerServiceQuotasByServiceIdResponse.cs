namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/partner/servicequotas/service-id/{service_id} 接口的响应。</para>
    /// </summary>
    public class GetPayScorePartnerServiceQuotasByServiceIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Quota
            {
                /// <summary>
                /// 获取或设置用户分层。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("risk_level")]
                [System.Text.Json.Serialization.JsonPropertyName("risk_level")]
                public int RiskLevel { get; set; }

                /// <summary>
                /// 获取或设置建议先享金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggested_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("suggested_quota")]
                public int SuggestedQuota { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置分层版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_level_version")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_level_version")]
        public int RiskLevelVersion { get; set; }

        /// <summary>
        /// 获取或设置先享金额列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quotas")]
        [System.Text.Json.Serialization.JsonPropertyName("quotas")]
        public Types.Quota[] QuotaList { get; set; } = default!;
    }
}
