namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/auditstrategy/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductAuditStrategyGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuditStrategy
            {
                /// <summary>
                /// 获取或设置隐藏商品信息上架开关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hide_err_field_flag")]
                [System.Text.Json.Serialization.JsonPropertyName("hide_err_field_flag")]
                public int HideErrorFieldFlag { get; set; }

                /// <summary>
                /// 获取或设置可上架相似品开关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hit_duplicated_flag")]
                [System.Text.Json.Serialization.JsonPropertyName("hit_duplicated_flag")]
                public int HitDuplicatedFlag { get; set; }

                /// <summary>
                /// 获取或设置命中低风险规则可上架开关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hit_low_risk_rule_flag")]
                [System.Text.Json.Serialization.JsonPropertyName("hit_low_risk_rule_flag")]
                public int HitLowRiskRuleFlag { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置上架策略信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_strategy")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_strategy")]
        public Types.AuditStrategy AuditStrategy { get; set; } = default!;
    }
}
