namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/specapi/get_job_result 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataSecurityApiGetJobResultResponse : WechatWorkResponse
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
                public string JobType { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务结果数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public string? DataString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置任务开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispatch_time")]
        [System.Text.Json.Serialization.JsonPropertyName("dispatch_time")]
        public long DispatchTimestamp { get; set; }

        /// <summary>
        /// 获取或设置任务进度（单位：百分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progress")]
        [System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int Progress { get; set; }

        /// <summary>
        /// 获取或设置结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }
    }
}
