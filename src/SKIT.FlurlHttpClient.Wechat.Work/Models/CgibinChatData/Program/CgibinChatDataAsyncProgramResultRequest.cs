namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/async_program_result 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataAsyncProgramResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = string.Empty;
    }
}
