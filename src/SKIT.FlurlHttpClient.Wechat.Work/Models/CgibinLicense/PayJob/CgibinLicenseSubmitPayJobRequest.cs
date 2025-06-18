namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/submit_pay_job 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseSubmitPayJobRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付人成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_userid")]
        public string PayerUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
