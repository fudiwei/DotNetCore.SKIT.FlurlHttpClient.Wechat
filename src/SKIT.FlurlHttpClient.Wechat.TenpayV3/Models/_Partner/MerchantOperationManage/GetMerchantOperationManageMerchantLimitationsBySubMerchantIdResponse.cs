namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch-operation-manage/merchant-limitations/sub-mchid/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class GetMerchantOperationManageMerchantLimitationsBySubMerchantIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class RecoverySpecification
            {
                /// <summary>
                /// 获取或设置商户被管控原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limitation_reason_type")]
                [System.Text.Json.Serialization.JsonPropertyName("limitation_reason_type")]
                public string? LimitationReasonType { get; set; }

                /// <summary>
                /// 获取或设置商户被管控原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limitation_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("limitation_reason")]
                public string? LimitationReason { get; set; }

                /// <summary>
                /// 获取或设置商户被该原因管控的解脱路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recover_way")]
                [System.Text.Json.Serialization.JsonPropertyName("recover_way")]
                public string? RecoverWay { get; set; }

                /// <summary>
                /// 获取或设置商户被该原因管控的解脱帮助链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recover_help_url")]
                [System.Text.Json.Serialization.JsonPropertyName("recover_help_url")]
                public string? RecoverHelpUrl { get; set; }

                /// <summary>
                /// 获取或设置商户被该原因管控的能力列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relate_limitations")]
                [System.Text.Json.Serialization.JsonPropertyName("relate_limitations")]
                public string[]? RelateLimitationList { get; set; }

                /// <summary>
                /// 获取或设置商户被该原因管控的其他能力描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_relate_limitations")]
                [System.Text.Json.Serialization.JsonPropertyName("other_relate_limitations")]
                public string? OtherRelateLimitation { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户被管控能力列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limited_functions")]
        [System.Text.Json.Serialization.JsonPropertyName("limited_functions")]
        public string[]? LimitedFunctionList { get; set; }

        /// <summary>
        /// 获取或设置被管控原因及解脱路径列表列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recovery_specifications")]
        [System.Text.Json.Serialization.JsonPropertyName("recovery_specifications")]
        public Types.RecoverySpecification[]? RecoverySpecificationList { get; set; }

        /// <summary>
        /// 获取或设置商户其他被管控能力描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other_limited_functions")]
        [System.Text.Json.Serialization.JsonPropertyName("other_limited_functions")]
        public string? OtherLimitedFunction { get; set; }
    }
}
