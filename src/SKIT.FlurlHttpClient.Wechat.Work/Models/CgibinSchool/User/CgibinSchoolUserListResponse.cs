namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/list 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__Student
            {
                /// <summary>
                /// 获取或设置学生账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("student_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                public string? StudentUserId { get; set; }

                /// <summary>
                /// 获取或设置学生姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置学生所在的部门 ID（即班级）列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public List<long>? DepartmentIdList { get; set; }
            }

            public class Student : __zz__Student
            {
                public static class Types
                {
                    public class Parent
                    {
                        /// <summary>
                        /// 获取或设置家长账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
                        public string? ParentUserId { get; set; }

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public string? MobileNumber { get; set; }

                        /// <summary>
                        /// 获取或设置家长与学生的关系。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("relation")]
                        [System.Text.Json.Serialization.JsonPropertyName("relation")]
                        public string? Relation { get; set; }

                        /// <summary>
                        /// 获取或设置是否关注了“学校通知”。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_subscribe")]
                        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                        public bool IsSubscribe { get; set; }

                        /// <summary>
                        /// 获取或设置外部联系人账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                        public string? ExternalUserId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置学生的家长列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parents")]
                [System.Text.Json.Serialization.JsonPropertyName("parents")]
                public List<Types.Parent>? Parents { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置学生列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("students")]
        [System.Text.Json.Serialization.JsonPropertyName("students")]
        public List<Types.Student>? StudentList { get; set; }
    }
}
