namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/icp/get_icp_entrance_info 接口的响应。</para>
    /// </summary>
    public class WxaICPGetICPEntranceInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class EntranceInfo
            {
                public static class Types
                {
                    public class AuditData
                    {
                        /// <summary>
                        /// 获取或设置字段中文名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("key_name")]
                        public string KeyName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error")]
                        [System.Text.Json.Serialization.JsonPropertyName("error")]
                        public string Error { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置修改建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("suggest")]
                        [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                        public string? Suggestion { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置备案状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置是否正在注销备案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_canceling")]
                [System.Text.Json.Serialization.JsonPropertyName("is_canceling")]
                public bool IsCanceling { get; set; }

                /// <summary>
                /// 获取或设置驳回原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_data")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_data")]
                public Types.AuditData[]? AuditDataList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置备案状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.EntranceInfo EntranceInfo { get; set; } = default!;
    }
}
