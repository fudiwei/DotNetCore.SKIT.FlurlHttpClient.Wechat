using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/favor/media/image-upload 接口的响应。</para>
    /// </summary>
    public class UploadMarketingMediaImageResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_url")]
        [System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string MediaUrl { get; set; } = default!;
    }
}
