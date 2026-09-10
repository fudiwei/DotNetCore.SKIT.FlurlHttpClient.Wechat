using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/file_upload_init 接口的请求。</para>
    /// </summary>
    public class CgibinWedocFileUploadInitRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// 获取或设置分块累积 SHA 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("block_sha")]
        [System.Text.Json.Serialization.JsonPropertyName("block_sha")]
        public IList<string> BlockShaList { get; set; } = new List<string>();
    }
}
