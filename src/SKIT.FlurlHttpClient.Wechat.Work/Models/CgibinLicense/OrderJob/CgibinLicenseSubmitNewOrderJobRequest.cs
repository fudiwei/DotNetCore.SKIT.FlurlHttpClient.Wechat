namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/submit_new_order_job 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseSubmitNewOrderJobRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置多企业新购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单人成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_userid")]
        public string BuyerUserId { get; set; } = string.Empty;
    }
}
