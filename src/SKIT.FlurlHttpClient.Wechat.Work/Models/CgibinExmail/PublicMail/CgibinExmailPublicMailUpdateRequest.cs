using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/update 接口的请求。</para>
    /// </summary>
    public class CgibinExmailPublicMailUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class UserIdList : CgibinExmailPublicMailCreateRequest.Types.UserIdList
            {
            }

            public class TagIdList : CgibinExmailPublicMailCreateRequest.Types.TagIdList
            {
            }

            public class DepartmentIdList : CgibinExmailPublicMailCreateRequest.Types.DepartmentIdList
            {
            }

            public class AliasList
            {
                /// <summary>
                /// 获取或设置别名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public IList<string> Items { get; set; } = new List<string>();
            }

            public class AuthCodeInfo : CgibinExmailPublicMailCreateRequest.Types.AuthCodeInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置业务邮箱 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置业务邮箱名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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

        /// <summary>
        /// 获取或设置企业邮箱别名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias_list")]
        [System.Text.Json.Serialization.JsonPropertyName("alias_list")]
        public Types.AliasList? AliasList { get; set; }

        /// <summary>
        /// 获取或设置是否创建客户端专用密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_auth_code")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_auth_code")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsCreateAuthCode { get; set; }

        /// <summary>
        /// 获取或设置客户端专用密码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code_info")]
        public Types.AuthCodeInfo? AuthCodeInfo { get; set; }
    }
}
