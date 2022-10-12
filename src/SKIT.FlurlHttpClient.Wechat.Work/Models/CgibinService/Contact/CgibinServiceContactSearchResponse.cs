namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/search 接口的响应。</para>
    /// </summary>
    public class CgibinServiceContactSearchResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class QueryResult
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置查询到的用户 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string[]? UserIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置查询到的用户 OpenUserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                        public string[]? OpenUserIdList { get; set; } = default!;
                    }

                    public class Department
                    {
                        /// <summary>
                        /// 获取或设置查询到的部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("department_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("department_id")]
                        public long[]? DepartmentIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置查询到的用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public Types.User? User { get; set; }

                /// <summary>
                /// 获取或设置查询到的部门信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("party")]
                [System.Text.Json.Serialization.JsonPropertyName("party")]
                public Types.Department? Department { get; set; }

                /// <summary>
                /// 获取或设置查询到的已离职用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dismiss_user")]
                [System.Text.Json.Serialization.JsonPropertyName("dismiss_user")]
                public Types.User? DismissUser { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置搜索结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_result")]
        [System.Text.Json.Serialization.JsonPropertyName("query_result")]
        public Types.QueryResult QueryResult { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_last")]
        [System.Text.Json.Serialization.JsonPropertyName("is_last")]
        public bool IsLast { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
