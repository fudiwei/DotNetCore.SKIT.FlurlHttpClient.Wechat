using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/specapi/create_job 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class CgibinChatDataSpecialApiCreateJobResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
