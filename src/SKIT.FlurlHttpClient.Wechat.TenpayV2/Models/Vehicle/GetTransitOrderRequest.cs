namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /transit/queryorder 接口的请求。</para>
    /// </summary>
    public class GetTransitOrderRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765

        /// <summary>
        /// 获取或设置商户订单号。与字段 <see cref="TransactionId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信订单号。与字段 <see cref="OutTradeNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }
    }
}
