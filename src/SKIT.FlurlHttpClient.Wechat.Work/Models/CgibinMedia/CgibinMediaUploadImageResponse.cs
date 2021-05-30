using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/uploadimg 接口的响应。</para>
    /// </summary>
    public class CgibinMediaUploadImageResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
