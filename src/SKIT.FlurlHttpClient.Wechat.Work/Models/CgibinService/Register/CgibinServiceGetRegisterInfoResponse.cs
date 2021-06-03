using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/get_register_info 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetRegisterInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ContactSync
            {
                /// <summary>
                /// 获取或设置通讯录迁移凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token")]
                public string AccessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置通讯录迁移凭证有效时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }
            }

            public class AuthorizerUser
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置通讯录迁移信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_sync")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_sync")]
        public Types.ContactSync? ContactSync { get; set; }

        /// <summary>
        /// 获取或设置授权管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_user_info")]
        public Types.AuthorizerUser? AuthorizerUser { get; set; }

        /// <summary>
        /// 获取或设置推广包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义渠道参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }
    }
}
