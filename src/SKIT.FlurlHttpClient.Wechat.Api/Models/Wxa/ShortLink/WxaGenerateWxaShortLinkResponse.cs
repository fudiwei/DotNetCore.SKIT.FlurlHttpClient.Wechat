using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/genwxashortlink 接口的响应。</para>
    /// </summary>
    public class WxaGenerateWxaShortLinkResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置生成的小程序 Short Link。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public string ShortLink { get; set; } = default!;
    }
}
