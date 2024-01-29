namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_withdraw_order 接口的响应。</para>
    /// </summary>
    public class XPayQueryWithdrawOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_no")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_no")]
        public string WithdrawNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置提现金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public decimal Amount { get; set; }

        /// <summary>
        /// 获取或设置提现状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置成功时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_success_timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_success_timestamp")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? SuccessTimestamp { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置微信内部提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_withdraw_no")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_withdraw_no")]
        public string WxWithdrawNumber { get; set; } = default!;
    }
}
