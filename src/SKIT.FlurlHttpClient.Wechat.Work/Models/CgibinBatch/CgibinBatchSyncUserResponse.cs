using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/syncuser 接口的响应。</para>
    /// </summary>
    public class CgibinBatchSyncUserResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置异步任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
