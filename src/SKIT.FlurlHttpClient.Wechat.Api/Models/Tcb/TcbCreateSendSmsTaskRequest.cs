using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/createsendsmstask 接口的请求。</para>
    /// </summary>
    public class TcbCreateSendSmsTaskRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置短信 CSV 文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_url")]
        [System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string FileUrl { get; set; } = string.Empty;
    }
}
