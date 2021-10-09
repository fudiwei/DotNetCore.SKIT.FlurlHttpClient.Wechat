using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/assetsupload/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiAssetsUploadResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filekey")]
        [System.Text.Json.Serialization.JsonPropertyName("filekey")]
        public string FileKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
