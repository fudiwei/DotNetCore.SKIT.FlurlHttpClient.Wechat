namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/agent/get_allow_scope 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolAgentGetAllowScopeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Scope
            {
                public static class Types
                {
                    public class Student
                    {
                        /// <summary>
                        /// 获取或设置学生的 UserId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置可使用的学生列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("students")]
                [System.Text.Json.Serialization.JsonPropertyName("students")]
                public Types.Student[] StudentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置可使用的部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("departments")]
                [System.Text.Json.Serialization.JsonPropertyName("departments")]
                public int[] DepartmentIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置可使用的家长范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_scope")]
        public Types.Scope AllowScope { get; set; } = default!;
    }
}
