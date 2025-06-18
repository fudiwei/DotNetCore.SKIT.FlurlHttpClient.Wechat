namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/icp/create_icp_verifytask 接口的响应。</para>
    /// </summary>
    public class WxaICPCreateICPVerifyTaskResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置人脸核身任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = default!;
    }
}
