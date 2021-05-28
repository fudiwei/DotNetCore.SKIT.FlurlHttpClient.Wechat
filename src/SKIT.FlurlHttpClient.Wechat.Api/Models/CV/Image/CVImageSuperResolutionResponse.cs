using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/img/superresolution 接口的响应。</para>
    /// </summary>
    public class CVImageSuperResolutionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置超清化图片媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;
    }
}
