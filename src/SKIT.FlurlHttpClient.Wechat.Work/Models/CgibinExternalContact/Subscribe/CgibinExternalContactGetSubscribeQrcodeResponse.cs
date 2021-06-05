using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/get_subscribe_qr_code 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetSubscribeQrcodeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置大尺寸二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_big")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_big")]
        public string BigSizeQrcodeUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置中尺寸二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_middle")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_middle")]
        public string MiddleSizeQrcodeUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置小尺寸二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_thumb")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_thumb")]
        public string SmallSizeQrcodeUrl { get; set; } = default!;
    }
}
