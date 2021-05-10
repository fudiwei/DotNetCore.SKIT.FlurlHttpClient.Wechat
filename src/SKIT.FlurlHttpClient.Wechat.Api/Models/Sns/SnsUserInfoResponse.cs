using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/userinfo 接口的响应。</para>
    /// </summary>
    public class SnsUserInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户全局标识。只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置用户的昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的性别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sex")]
        [System.Text.Json.Serialization.JsonPropertyName("sex")]
        public int Sex { get; set; }

        /// <summary>
        /// 获取或设置用户所在城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string City { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户所在省份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        [System.Text.Json.Serialization.JsonPropertyName("province")]
        public string Province { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户所在国家。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country")]
        [System.Text.Json.Serialization.JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headimgurl")]
        [System.Text.Json.Serialization.JsonPropertyName("headimgurl")]
        public string HeadImageUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户特权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privilege")]
        [System.Text.Json.Serialization.JsonPropertyName("privilege")]
        public string[]? PrivilegeList { get; set; }
    }
}
