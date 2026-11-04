namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/list_parent 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserListParentResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__Parent
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

            public class Parent : __zz__Parent
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
                        public string? StudentUserId { get; set; }

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
                        public string? Relation { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置家长的孩子列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("children")]
                [System.Text.Json.Serialization.JsonPropertyName("children")]
                public List<Types.Child>? Children { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置家长列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parents")]
        [System.Text.Json.Serialization.JsonPropertyName("parents")]
        public List<Types.Parent>? ParentList { get; set; }
    }
}
