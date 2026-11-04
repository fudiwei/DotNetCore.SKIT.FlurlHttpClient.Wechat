namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/admin_oper_log/list 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityAdministratorOperateLogListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record : CgibinSecurityMemberOperateLogListResponse.Types.Record
            {
                /// <summary>
                /// 获取或设置操作行为类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_type")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_type")]
                public int DetailType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("record_list")]
        public List<Types.Record>? RecordList { get; set; }

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
