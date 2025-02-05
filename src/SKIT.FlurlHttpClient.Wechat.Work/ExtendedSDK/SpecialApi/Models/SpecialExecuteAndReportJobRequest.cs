using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /spec/exec_and_report_job 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class SpecialExecuteAndReportJobRequest : WechatWorkSpecialApiRequest
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置任务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("job_type")]
                [System.Text.Json.Serialization.JsonPropertyName("job_type")]
                public string JobType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置任务结果数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public string? DataString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置任务进度（单位：百分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progress")]
        [System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 获取或设置结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }
    }
}
