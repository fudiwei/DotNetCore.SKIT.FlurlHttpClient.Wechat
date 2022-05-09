using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /file-uploads 接口的请求。</para>
    /// </summary>
    public class UploadFileRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置图片文件名（必须以 jpg、bmp、png 为后缀）。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置图片文件摘要。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sm3")]
        [System.Text.Json.Serialization.JsonPropertyName("sm3")]
        public string? FileHash { get; set; }

        /// <summary>
        /// 获取或设置图片文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }
    }
}
