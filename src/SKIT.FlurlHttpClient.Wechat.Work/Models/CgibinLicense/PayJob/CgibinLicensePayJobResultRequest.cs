namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/pay_job_result 接口的请求。</para>
    /// </summary>
    public class CgibinLicensePayJobResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = string.Empty;
    }
}
