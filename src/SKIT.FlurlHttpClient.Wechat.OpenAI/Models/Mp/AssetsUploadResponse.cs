using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /assetsupload/{TOKEN} 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-07 下线。")]
    public class AssetsUploadResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? ReturnMessage { get; set; }

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
