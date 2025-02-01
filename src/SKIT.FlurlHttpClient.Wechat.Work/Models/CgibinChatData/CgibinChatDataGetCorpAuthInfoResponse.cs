namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/get_corp_auth_info 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataGetCorpAuthInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AuthEdition
            {
                public static class Types
                {
                    public class AuthScope
                    {
                        /// <summary>
                        /// 获取或设置企业授权存档的成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置企业授权存档的部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("department_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("department_id_list")]
                        public long[]? DepartmentIdList { get; set; }

                        /// <summary>
                        /// 获取或设置企业授权存档的标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_id_list")]
                        public long[]? TagIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会话版本类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edition")]
                [System.Text.Json.Serialization.JsonPropertyName("edition")]
                public int Edition { get; set; }

                /// <summary>
                /// 获取或设置授权范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_scope")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_scope")]
                public Types.AuthScope AuthScope { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置开始生效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束生效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置会话授权的天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_duration_days")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_duration_days")]
                public int MessageDurationDays { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业授权的会话版本列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_edition_list")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_edition_list")]
        public Types.AuthEdition[] AuthEditionList { get; set; } = default!;
    }
}
