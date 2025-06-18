namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/profit-allocations/finish 接口的请求。</para>
    /// </summary>
    public class SetProfitAllocationFinishedRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置企业商户 ID。如果不指定将使用构造 <see cref="WechatTenpayBusinessClient"/> 时的 <see cref="WechatTenpayBusinessClientOptions.EnterpriseId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_allocation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_allocation_id")]
        public string OutAllocationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分账原因描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置分账状态通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("server_notify_url")]
        public string ServerNotifyUrl { get; set; } = string.Empty;
    }
}
