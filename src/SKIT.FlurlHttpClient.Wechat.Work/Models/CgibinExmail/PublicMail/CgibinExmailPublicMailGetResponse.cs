namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/get 接口的响应。</para>
    /// </summary>
    public class CgibinExmailPublicMailGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Mail
            {
                public static class Types
                {
                    public class UserIdList
                    {
                        /// <summary>
                        /// 获取或设置成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("list")]
                        [System.Text.Json.Serialization.JsonPropertyName("list")]
                        public string[] Items { get; set; } = default!;
                    }

                    public class TagIdList : CgibinExmailGroupGetResponse.Types.TagIdList
                    {
                    }

                    public class DepartmentIdList : CgibinExmailGroupGetResponse.Types.DepartmentIdList
                    {
                    }
                }

                /// <summary>
                /// 获取或设置业务邮箱 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置业务邮箱地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string Email { get; set; } = default!;

                /// <summary>
                /// 获取或设置业务邮箱名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置允许使用的成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
                public Types.UserIdList? AllowUserIdList { get; set; }

                /// <summary>
                /// 获取或设置允许使用的标签 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                public Types.TagIdList? AllowTagIdList { get; set; }

                /// <summary>
                /// 获取或设置允许使用的部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_list")]
                [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                public Types.DepartmentIdList? AllowDepartmentIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务邮箱列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Mail[] MailList { get; set; } = default!;
    }
}
