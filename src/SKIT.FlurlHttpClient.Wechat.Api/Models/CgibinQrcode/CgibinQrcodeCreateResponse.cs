using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/qrcode/create 接口的响应。</para>
    /// </summary>
    public class CgibinQrcodeCreateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置获取二维码的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string Ticket { get; set; } = default!;

        /// <summary>
        /// 获取或设置二维码图片解析后的地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
