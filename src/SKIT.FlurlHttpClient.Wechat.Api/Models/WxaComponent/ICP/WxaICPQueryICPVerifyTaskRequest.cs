namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/icp/query_icp_verifytask 接口的请求。</para>
    /// </summary>
    public class WxaICPQueryICPVerifyTaskRequest : WechatApiRequest, IInferable<WxaICPQueryICPVerifyTaskRequest, WxaICPQueryICPVerifyTaskResponse>
    {
        /// <summary>
        /// 获取或设置人脸核身任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;
    }
}
