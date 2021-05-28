using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyerrelationbybuyer 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerRelationByBuyerResponse : WechatApiResponse
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
        /// 获取或设置客户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string BuyerOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置客户微信昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_nickname")]
        public string BuyerNickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
