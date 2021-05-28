using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/guidecreateqrcode 接口的响应。</para>
    /// </summary>
    public class CgibinGuideCreateQrcodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
