namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/adddelayedfunctiontask 接口的请求。</para>
    /// </summary>
    public class TCBAddDelayedFunctionTaskRequest : WechatApiRequest, IInferable<TCBAddDelayedFunctionTaskRequest, TCBAddDelayedFunctionTaskResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("function_name")]
        [System.Text.Json.Serialization.JsonPropertyName("function_name")]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置延迟时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("delay_time")]
        public int DelayTime { get; set; }

        /// <summary>
        /// 获取或设置发送的 JSON 格式数据包。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? JsonData { get; set; }
    }
}
