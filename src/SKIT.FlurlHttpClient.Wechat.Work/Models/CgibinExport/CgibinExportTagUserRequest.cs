using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/export/taguser 接口的请求。</para>
    /// </summary>
    public class CgibinExportTagUserRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int TagId { get; set; }

        /// <summary>
        /// 获取或设置 Base64 编码的加密密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encoding_aeskey")]
        [System.Text.Json.Serialization.JsonPropertyName("encoding_aeskey")]
        public string EncodingAESKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置每块数据的人员数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("block_size")]
        [System.Text.Json.Serialization.JsonPropertyName("block_size")]
        public int? BlockSize { get; set; }
    }
}
