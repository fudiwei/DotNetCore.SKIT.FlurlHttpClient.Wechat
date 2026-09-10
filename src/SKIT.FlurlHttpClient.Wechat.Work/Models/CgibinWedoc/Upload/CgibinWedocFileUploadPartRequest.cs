using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/file_upload_part 接口的请求。</para>
    /// </summary>
    public class CgibinWedocFileUploadPartRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文件上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_key")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_key")]
        public string UploadKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件分块号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index")]
        [System.Text.Json.Serialization.JsonPropertyName("index")]
        public int BlockIndex { get; set; }

        /// <summary>
        /// 获取或设置文件分块字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_base64_content")]
        [System.Text.Json.Serialization.JsonPropertyName("file_base64_content")]
        public byte[] BlockBytes { get; set; } = Array.Empty<byte>();
    }
}
