namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getdramalatestauditinfo 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetDramaLatestAuditInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuditDetail
            {
                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置提审时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置审核时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                public long? AuditTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置审核信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
        public Types.AuditDetail AuditDetail { get; set; } = default!;
    }
}
