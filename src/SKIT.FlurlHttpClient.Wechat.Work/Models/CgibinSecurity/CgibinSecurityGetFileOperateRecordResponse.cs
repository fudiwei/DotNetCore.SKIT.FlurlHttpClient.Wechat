namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/get_file_oper_record 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityGetFileOperateRecordResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                public static class Types
                {
                    public class Operation
                    {
                        /// <summary>
                        /// 获取或设置操作类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置操作来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public int? Source { get; set; }
                    }

                    public class ExternalUser
                    {
                        /// <summary>
                        /// 获取或设置用户类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置用户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业微信用户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corp_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                        public string? CorpName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置企业用户 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置企业外部人员帐号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_user")]
                [System.Text.Json.Serialization.JsonPropertyName("external_user")]
                public Types.ExternalUser? ExternalUser { get; set; }

                /// <summary>
                /// 获取或设置操作信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operation")]
                [System.Text.Json.Serialization.JsonPropertyName("operation")]
                public Types.Operation Operation { get; set; } = default!;

                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置文件操作说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_info")]
                [System.Text.Json.Serialization.JsonPropertyName("file_info")]
                public string? FileInfo { get; set; }

                /// <summary>
                /// 获取或设置申请人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applicant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("applicant_name")]
                public string? ApplicantName { get; set; }
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
