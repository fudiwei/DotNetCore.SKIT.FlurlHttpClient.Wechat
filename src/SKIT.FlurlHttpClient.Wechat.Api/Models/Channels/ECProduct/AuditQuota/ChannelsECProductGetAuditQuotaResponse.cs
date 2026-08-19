namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/getauditquota 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductGetAuditQuotaResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuditQuota
            {
                /// <summary>
                /// 获取或设置是否已被限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("block_status")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("block_status")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsBlocked { get; set; }

                /// <summary>
                /// 获取或设置可用配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avail_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("avail_quota")]
                public int AvailableQuota { get; set; }

                /// <summary>
                /// 获取或设置总配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("total_quota")]
                public int TotalQuota { get; set; }

                /// <summary>
                /// 获取或设置是否不限制提审。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unlimited_type")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("unlimited_type")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsUnlimitedAudit { get; set; }

                /// <summary>
                /// 获取或设置审核总配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_total_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_total_quota")]
                public int AuditTotalQuota { get; set; }

                /// <summary>
                /// 获取或设置审核剩余配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_total_remaining")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_total_remaining")]
                public int AuditRemainingQuota { get; set; }

                /// <summary>
                /// 获取或设置新增商品审核总配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_product_total_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("new_product_total_quota")]
                public int NewProductTotalQuota { get; set; }

                /// <summary>
                /// 获取或设置新增商品审核剩余配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_product_remaining")]
                [System.Text.Json.Serialization.JsonPropertyName("new_product_remaining")]
                public int NewProductRemainingQuota { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置审核限额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_quota")]
        public Types.AuditQuota AuditQuota { get; set; } = default!;
    }
}
