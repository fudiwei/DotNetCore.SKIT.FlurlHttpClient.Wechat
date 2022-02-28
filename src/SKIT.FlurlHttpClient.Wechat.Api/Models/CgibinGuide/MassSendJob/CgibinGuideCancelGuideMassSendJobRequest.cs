namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/cancelguidemassendjob 接口的请求。</para>
    /// </summary>
    public class CgibinGuideCancelGuideMassSendJobRequest : WechatApiRequest, IInferable<CgibinGuideCancelGuideMassSendJobRequest, CgibinGuideCancelGuideMassSendJobResponse>
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
