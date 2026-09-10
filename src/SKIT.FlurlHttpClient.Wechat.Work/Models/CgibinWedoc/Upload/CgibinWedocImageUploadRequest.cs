using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/image_upload 接口的请求。</para>
    /// </summary>
    public class CgibinWedocImageUploadRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base64_content")]
        [System.Text.Json.Serialization.JsonPropertyName("base64_content")]
        public byte[] ImageFileBytes { get; set; } = Array.Empty<byte>();
    }
}
