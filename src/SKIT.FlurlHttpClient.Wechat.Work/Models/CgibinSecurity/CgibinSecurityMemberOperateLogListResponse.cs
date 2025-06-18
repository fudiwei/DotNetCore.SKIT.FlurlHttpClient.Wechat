namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/member_oper_log/list 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityMemberOperateLogListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置操作者 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oper_type")]
                [System.Text.Json.Serialization.JsonPropertyName("oper_type")]
                public int OperateType { get; set; }

                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置相关数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_info")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_info")]
                public string? DetailInfo { get; set; }

                /// <summary>
                /// 获取或设置操作者 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string? Ip { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("record_list")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
