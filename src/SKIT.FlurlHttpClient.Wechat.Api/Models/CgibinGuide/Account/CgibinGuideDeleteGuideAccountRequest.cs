﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/delguideacct 接口的请求。</para>
    /// </summary>
    public class CgibinGuideDeleteGuideAccountRequest : WechatApiRequest, IInferable<CgibinGuideDeleteGuideAccountRequest, CgibinGuideDeleteGuideAccountResponse>
    {
        /// <summary>
        /// 获取或设置顾问微信号。与字段 <see cref="GuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string? GuideAccount { get; set; }

        /// <summary>
        /// 获取或设置顾问 OpenId。与字段 <see cref="GuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_openid")]
        public string? GuideOpenId { get; set; }
    }
}
