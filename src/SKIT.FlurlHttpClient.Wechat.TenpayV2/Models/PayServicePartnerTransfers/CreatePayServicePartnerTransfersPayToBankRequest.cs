namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaysptrans/pay_bank 接口的请求。</para>
    /// </summary>
    public class CreatePayServicePartnerTransfersPayToBankRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_trade_no")]
        public string PartnerTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置收款方开户行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_code")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_code")]
        public string BankCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款方银行卡号（需使用平台提供的 RSA 公钥加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enc_bank_no")]
        [System.Text.Json.Serialization.JsonPropertyName("enc_bank_no")]
        public string BankAccountNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款方用户名（需使用平台提供的 RSA 公钥加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enc_true_name")]
        [System.Text.Json.Serialization.JsonPropertyName("enc_true_name")]
        public string RealName { get; set; } = string.Empty;
    }
}
