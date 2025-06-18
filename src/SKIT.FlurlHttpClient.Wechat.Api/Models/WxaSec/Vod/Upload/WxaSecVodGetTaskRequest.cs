namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/gettask 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetTaskRequest : WechatApiRequest, IInferable<WxaSecVodGetTaskRequest, WxaSecVodGetTaskResponse>
    {
        /// <summary>
        /// 获取或设置拉取上传任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
