using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/tag/get 接口的响应。</para>
    /// </summary>
    public class CgibinTagGetResponse : WechatWorkResponse
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
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagname")]
        [System.Text.Json.Serialization.JsonPropertyName("tagname")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置标签中包含的成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userlist")]
        [System.Text.Json.Serialization.JsonPropertyName("userlist")]
        public Types.User[] UserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置标签中包含的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partylist")]
        [System.Text.Json.Serialization.JsonPropertyName("partylist")]
        public int[] DepartmentIdList { get; set; } = default!;
    }
}
