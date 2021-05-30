using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_contact_way 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactAddContactWayResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置配置 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_id")]
        [System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string ConfigId { get; set; } = default!;

        /// <summary>
        /// 获取或设置联系我的二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
        public string? QrcodeUrl { get; set; }
    }
}
