namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/get 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Student
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
                        public string ParentUserId { get; set; } = default!;

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
                        public string Relation { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否关注了“学校通知”。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_subscribe")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
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
                /// 获取或设置学生账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("student_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                public string StudentUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置学生姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置学生所在的部门 ID（即班级）列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public int[] DepartmentIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置学生的家长列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parents")]
                [System.Text.Json.Serialization.JsonPropertyName("parents")]
                public Types.Parent[] Parents { get; set; } = default!;
            }

            public class Parent
            {
                public static class Types
                {
                    public class Child
                    {
                        /// <summary>
                        /// 获取或设置学生账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("student_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                        public string StudentUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置学生姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置家长与学生的关系。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("relation")]
                        [System.Text.Json.Serialization.JsonPropertyName("relation")]
                        public string Relation { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置家长账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
                public string ParentUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string MobileNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置家长的孩子列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("children")]
                [System.Text.Json.Serialization.JsonPropertyName("children")]
                public Types.Child[] Children { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否关注了“学校通知”。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_subscribe")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
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
        /// 获取或设置用户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_type")]
        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
        public int UserType { get; set; }

        /// <summary>
        /// 获取或设置学生信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student")]
        [System.Text.Json.Serialization.JsonPropertyName("student")]
        public Types.Student? Student { get; set; }

        /// <summary>
        /// 获取或设置家长信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent")]
        [System.Text.Json.Serialization.JsonPropertyName("parent")]
        public Types.Parent? Parent { get; set; }
    }
}
