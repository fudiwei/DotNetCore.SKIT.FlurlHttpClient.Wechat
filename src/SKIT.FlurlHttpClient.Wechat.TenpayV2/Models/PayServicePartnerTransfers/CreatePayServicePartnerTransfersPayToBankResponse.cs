namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaysptrans/pay_bank 接口的响应。</para>
    /// </summary>
    public class CreatePayServicePartnerTransfersPayToBankResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（请忽略此字段）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_trade_no")]
        public string PartnerTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置微信付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_no")]
        public string PaymentNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置手续费金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmms_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("cmms_amt")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int CMMSAmount { get; set; }
    }
}
