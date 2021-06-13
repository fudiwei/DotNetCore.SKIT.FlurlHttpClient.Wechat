namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/update_store 接口的响应。</para>
    /// </summary>
    public class WxaUpdateStoreResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否需要审核。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_audit_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("has_audit_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                public bool RequireAudit { get; set; }

                /// <summary>
                /// 获取或设置审核单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                public int? AuditId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
