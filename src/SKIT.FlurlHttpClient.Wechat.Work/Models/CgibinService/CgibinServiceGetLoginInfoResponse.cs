using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_login_info 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetLoginInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置第三方成员唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string? OpenUserId { get; set; }

                /// <summary>
                /// 获取或设置成员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string? AvatarUrl { get; set; }
            }

            public class Corp
            {
                /// <summary>
                /// 获取或设置企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;
            }

            public class Agent
            {
                /// <summary>
                /// 获取或设置应用 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agentid")]
                [System.Text.Json.Serialization.JsonPropertyName("agentid")]
                public int AgentId { get; set; }

                /// <summary>
                /// 获取或设置应用权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
                public int AuthType { get; set; }
            }

            public class Authorization
            {
                public static class Types
                {
                    public class Department
                    {
                        /// <summary>
                        /// 获取或设置部门 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int DepartmentId { get; set; }

                        /// <summary>
                        /// 获取或设置是否有可写权限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("writable")]
                        [System.Text.Json.Serialization.JsonPropertyName("writable")]
                        public bool Writable { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置部门列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public Types.Department[] DepartmentList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置登录用户的类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usertype")]
        [System.Text.Json.Serialization.JsonPropertyName("usertype")]
        public int UserType { get; set; }

        /// <summary>
        /// 获取或设置登录用户的信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.User User { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_info")]
        public Types.Corp Corp { get; set; } = default!;

        /// <summary>
        /// 获取或设置应用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent")]
        [System.Text.Json.Serialization.JsonPropertyName("agent")]
        public Types.Agent[] AgentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置权限信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public Types.Authorization Authorization { get; set; } = default!;
    }
}
