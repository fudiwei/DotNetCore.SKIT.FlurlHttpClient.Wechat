namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/famousbrand/get_status 接口的响应。</para>
    /// </summary>
    public class WxaSecFamousBrandGetStatusResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Progress
            {
                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }

            public class Application
            {
                public static class Types
                {
                    public class AuditInfo
                    {
                        /// <summary>
                        /// 获取或设置审核原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                        public string? AuditReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置品牌申请类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_for")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_for")]
                public int ApplyForType { get; set; }

                /// <summary>
                /// 获取或设置审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                public Types.AuditInfo? AuditInfo { get; set; }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progress")]
        [System.Text.Json.Serialization.JsonPropertyName("progress")]
        public Types.Progress Progress { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application")]
        [System.Text.Json.Serialization.JsonPropertyName("application")]
        public Types.Application Application { get; set; } = default!;
    }
}
