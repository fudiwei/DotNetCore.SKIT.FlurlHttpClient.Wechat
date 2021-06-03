using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_create 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveSpaceCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class AuthorizedUser
            {
                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("departmentid")]
                [System.Text.Json.Serialization.JsonPropertyName("departmentid")]
                public int? DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth")]
                [System.Text.Json.Serialization.JsonPropertyName("auth")]
                public int Authority { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置空间标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_name")]
        [System.Text.Json.Serialization.JsonPropertyName("space_name")]
        public string SpaceName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置空间授权成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public IList<Types.AuthorizedUser>? AuthorizedUserList { get; set; }
    }
}
