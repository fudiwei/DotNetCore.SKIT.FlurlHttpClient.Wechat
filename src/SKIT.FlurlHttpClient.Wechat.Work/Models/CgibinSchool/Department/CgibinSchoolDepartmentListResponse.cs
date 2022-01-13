namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/department/list 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolDepartmentListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Department
            {
                public static class Types
                {
                    public class Administrator
                    {
                        /// <summary>
                        /// 获取或设置管理员成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置管理员类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置教师科目。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subject")]
                        [System.Text.Json.Serialization.JsonPropertyName("subject")]
                        public string? Subject { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置部门名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置部门类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置上级部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parentid")]
                [System.Text.Json.Serialization.JsonPropertyName("parentid")]
                public int ParentDepartmentId { get; set; }

                /// <summary>
                /// 获取或设置标准年级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("standard_grade")]
                [System.Text.Json.Serialization.JsonPropertyName("standard_grade")]
                public int? StandardGrade { get; set; }

                /// <summary>
                /// 获取或设置入学年份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_year")]
                [System.Text.Json.Serialization.JsonPropertyName("register_year")]
                public int? RegisterYear { get; set; }

                /// <summary>
                /// 获取或设置次序值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public long? Order { get; set; }

                /// <summary>
                /// 获取或设置部门管理员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_admins")]
                [System.Text.Json.Serialization.JsonPropertyName("department_admins")]
                public Types.Administrator[] AdministratorList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否已毕业。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_graduated")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_graduated")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsGraduated { get; set; }

                /// <summary>
                /// 获取或设置是否开启客户群（即班级群）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_group_chat")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("open_group_chat")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsOpenGroupChat { get; set; }

                /// <summary>
                /// 获取或设置客户群（即班级群）ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_chat_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string? GroupChatId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置部门列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("departments")]
        [System.Text.Json.Serialization.JsonPropertyName("departments")]
        public Types.Department[] DepartmentList { get; set; } = default!;
    }
}
