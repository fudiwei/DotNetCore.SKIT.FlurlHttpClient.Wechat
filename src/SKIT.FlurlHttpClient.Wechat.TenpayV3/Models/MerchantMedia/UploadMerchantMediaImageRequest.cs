using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/media/upload 接口的请求。</para>
    /// </summary>
    public class UploadMerchantMediaImageRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = new byte[0];

        /// <summary>
        /// 获取或设置图片文件名（必须以 jpg、bmp、png 为后缀）。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置图片文件摘要。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sha256")]
        [System.Text.Json.Serialization.JsonPropertyName("sha256")]
        public string? FileHash { get; set; }

        /// <summary>
        /// 获取或设置图片文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }
    }
}
