using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/guidecreateqrcode 接口的请求。</para>
    /// </summary>
    public class CgibinGuideCreateQrcodeRequest : WechatApiRequest
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

        /// <summary>
        /// 获取或设置二维码额外参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_info")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_info")]
        public string? QrcodeExt { get; set; }
    }
}
