using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/mpnews/gethtml 接口的响应。</para>
    /// </summary>
    public class CardMpnewsGetHtmlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 HTML 内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string ContentHtml { get; set; } = default!;
    }
}
