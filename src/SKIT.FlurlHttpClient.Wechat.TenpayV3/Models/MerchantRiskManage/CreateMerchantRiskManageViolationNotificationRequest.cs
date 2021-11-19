namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-risk-manage/violation-notifications 接口的请求。</para>
    /// </summary>
    public class CreateMerchantRiskManageViolationNotificationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;
    }
}
