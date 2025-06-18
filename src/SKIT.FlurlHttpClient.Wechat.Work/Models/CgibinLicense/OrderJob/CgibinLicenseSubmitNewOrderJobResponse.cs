namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/submit_new_order_job 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseSubmitNewOrderJobResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置多企业新购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
