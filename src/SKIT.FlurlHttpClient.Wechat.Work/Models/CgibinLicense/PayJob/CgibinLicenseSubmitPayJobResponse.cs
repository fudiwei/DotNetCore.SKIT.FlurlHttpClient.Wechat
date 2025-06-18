namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/submit_pay_job 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseSubmitPayJobResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置支付任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
