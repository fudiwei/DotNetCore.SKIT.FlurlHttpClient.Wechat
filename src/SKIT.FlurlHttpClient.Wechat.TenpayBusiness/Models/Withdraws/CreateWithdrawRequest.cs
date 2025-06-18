namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/withdraws 接口的请求。</para>
    /// </summary>
    public class CreateWithdrawRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置企业商户 ID。如果不指定将使用构造 <see cref="WechatTenpayBusinessClient"/> 时的 <see cref="WechatTenpayBusinessClientOptions.EnterpriseId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置提现账户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_acct_id")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_acct_id")]
        public string ReceiverAccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_withdraw_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_withdraw_id")]
        public string OutWithdrawId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置提现结果通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("server_notify_url")]
        public string ServerNotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现原因描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }
    }
}
