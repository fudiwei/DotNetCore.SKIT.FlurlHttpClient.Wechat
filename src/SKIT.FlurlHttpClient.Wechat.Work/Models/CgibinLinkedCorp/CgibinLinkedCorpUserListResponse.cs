using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/user/list 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CorpUser
            {
                public static class Types
                {
                    public class ExtendedAttribute : CgibinUserGetResponse.Types.ExtendedAttribute
                    { 
                    }
                }

                /// <summary>
                /// 获取或设置所属企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置座机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("telephone")]
                [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }

                /// <summary>
                /// 获取或设置职务。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("position")]
                [System.Text.Json.Serialization.JsonPropertyName("position")]
                public string? Position { get; set; }

                /// <summary>
                /// 获取或设置互联企业部门 ID（格式："LinkedId/DepartmentId"）列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public string[]? LinkedDepartmentIdList { get; set; }

                /// <summary>
                /// 获取或设置自定义字段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extattr")]
                [System.Text.Json.Serialization.JsonPropertyName("extattr")]
                public Types.ExtendedAttribute? ExtendedAttribute { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置互联企业成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userlist")]
        [System.Text.Json.Serialization.JsonPropertyName("userlist")]
        public Types.CorpUser[] CorpUserList { get; set; } = default!;
    }
}
