using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/guide/getguideacct 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideAccountResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置顾问微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string? GuideAccount { get; set; }

        /// <summary>
        /// 获取或设置顾问 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_openid")]
        public string? GuideOpenId { get; set; }

        /// <summary>
        /// 获取或设置顾问昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_nickname")]
        public string GuideNickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置顾问头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_headimgurl")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_headimgurl")]
        public string GuideHeadImageUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置顾问状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }
    }
}
