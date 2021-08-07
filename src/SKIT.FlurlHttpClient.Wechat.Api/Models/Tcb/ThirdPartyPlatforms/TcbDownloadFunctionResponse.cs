using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/downloadfunction 接口的响应。</para>
    /// </summary>
    public class TcbDownloadFunctionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置校验码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checksum")]
        [System.Text.Json.Serialization.JsonPropertyName("checksum")]
        public string Checksum { get; set; } = default!;
    }
}
