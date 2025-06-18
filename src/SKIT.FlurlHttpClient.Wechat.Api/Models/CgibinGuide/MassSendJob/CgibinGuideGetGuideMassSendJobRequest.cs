namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidemassendjob 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGuideMassSendJobRequest : WechatApiRequest, IInferable<CgibinGuideGetGuideMassSendJobRequest, CgibinGuideGetGuideMassSendJobResponse>
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
