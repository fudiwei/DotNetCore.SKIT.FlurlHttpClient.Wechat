using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/role/getrolelist 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastRoleGetRoleListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户微信号（已脱敏处理）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("username")]
                [System.Text.Json.Serialization.JsonPropertyName("username")]
                public string Username { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headingimg")]
                [System.Text.Json.Serialization.JsonPropertyName("headingimg")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置角色类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("roleList")]
                [System.Text.Json.Serialization.JsonPropertyName("roleList")]
                public int[] RoleList { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updateTimestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("updateTimestamp")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Member[] MemberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置成员总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
