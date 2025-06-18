namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/get_auth_code_list 接口的响应。</para>
    /// </summary>
    public class CgibinExmailPublicMailGetAuthCodeListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AuthCode
            {
                /// <summary>
                /// 获取或设置客户端专用密码 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_code_id")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_code_id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = default!;

                /// <summary>
                /// 获取或设置最后使用时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_use_time")]
                [System.Text.Json.Serialization.JsonPropertyName("last_use_time")]
                public long LastUseTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户端专用密码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code_list")]
        public Types.AuthCode[] AuthCodeList { get; set; } = default!;
    }
}
