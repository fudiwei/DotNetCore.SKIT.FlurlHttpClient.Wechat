using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/createpressuretesttask 接口的请求。</para>
    /// </summary>
    public class TcbCreatePressureTestTaskRequest : WechatApiRequest, IMapResponse<TcbCreatePressureTestTaskRequest, TcbCreatePressureTestTaskResponse>
    {
        /// <summary>
        /// 获取或设置压测页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_url")]
        [System.Text.Json.Serialization.JsonPropertyName("task_url")]
        public string TaskPagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 Worker 数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("run_count")]
        [System.Text.Json.Serialization.JsonPropertyName("run_count")]
        public int RunCount { get; set; }

        /// <summary>
        /// 获取或设置持续时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("run_time")]
        [System.Text.Json.Serialization.JsonPropertyName("run_time")]
        public int RunTime { get; set; }

        /// <summary>
        /// 获取或设置压测版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_type")]
        [System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public int SourceType { get; set; } = 4;
    }
}
