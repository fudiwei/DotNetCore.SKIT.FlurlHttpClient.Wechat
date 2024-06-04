using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /assetsupload/{TOKEN} 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-07 下线。")]
    public class AssetsUploadRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }
    }
}
