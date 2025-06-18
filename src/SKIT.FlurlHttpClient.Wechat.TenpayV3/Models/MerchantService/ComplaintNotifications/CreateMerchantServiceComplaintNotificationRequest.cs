namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-service/complaint-notifications 接口的请求。</para>
    /// </summary>
    public class CreateMerchantServiceComplaintNotificationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string NotifyUrl { get; set; } = string.Empty;
    }
}
