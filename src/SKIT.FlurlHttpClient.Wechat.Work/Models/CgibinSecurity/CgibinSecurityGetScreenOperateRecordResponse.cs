namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/get_screen_oper_record 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityGetScreenOperateRecordResponse : WechatWorkResponse
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
                /// 获取或设置操作者部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_id")]
                [System.Text.Json.Serialization.JsonPropertyName("department_id")]
                public long DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置截屏内容类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("screen_shot_type")]
                [System.Text.Json.Serialization.JsonPropertyName("screen_shot_type")]
                public int ScreenshotType { get; set; }

                /// <summary>
                /// 获取或设置截屏内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("screen_shot_content")]
                [System.Text.Json.Serialization.JsonPropertyName("screen_shot_content")]
                public string ScreenshotContent { get; set; } = default!;

                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置用户的操作系统。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system")]
                [System.Text.Json.Serialization.JsonPropertyName("system")]
                public string? System { get; set; }
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
