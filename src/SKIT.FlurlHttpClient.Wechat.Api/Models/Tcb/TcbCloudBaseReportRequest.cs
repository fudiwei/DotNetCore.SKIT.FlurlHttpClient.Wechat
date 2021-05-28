using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/cloudbasereport 接口的请求。</para>
    /// </summary>
    public class TcbCloudBaseReportRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置上报动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_action")]
        [System.Text.Json.Serialization.JsonPropertyName("report_action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_id")]
        [System.Text.Json.Serialization.JsonPropertyName("env_id")]
        public string EnvId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 获取或设置下发手机号数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_count")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_count")]
        public int? MobileNumberCount { get; set; }

        /// <summary>
        /// 获取或设置渠道 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_id")]
        [System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }
    }
}
