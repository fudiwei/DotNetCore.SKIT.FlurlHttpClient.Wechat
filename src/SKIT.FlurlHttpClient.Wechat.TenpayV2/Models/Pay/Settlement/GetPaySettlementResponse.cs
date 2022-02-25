namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/settlementquery 接口的响应。</para>
    /// </summary>
    public class GetPaySettlementResponse : WechatTenpaySignableResponse
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
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_num")]
        [System.Text.Json.Serialization.JsonPropertyName("record_num")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int RecordCount { get; set; }

        /// <summary>
        /// 获取或设置付汇批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fbatchno")]
        [System.Text.Json.Serialization.JsonPropertyName("fbatchno")]
        public string ForeignPaymentBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置结算日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_settlement")]
        [System.Text.Json.Serialization.JsonPropertyName("date_settlement")]
        public string SettlementDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易开始日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_start")]
        [System.Text.Json.Serialization.JsonPropertyName("date_start")]
        public string StartDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易结束日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_end")]
        [System.Text.Json.Serialization.JsonPropertyName("date_end")]
        public string EndDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置已划账金额（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_fee")]
        public int SettlementFee { get; set; }

        /// <summary>
        /// 获取或设置未划账金额（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unsettlement_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("unsettlement_fee")]
        public int UnsettlementFee { get; set; }

        /// <summary>
        /// 获取或设置交易币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlementfee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("settlementfee_type")]
        public string SettlementFeeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置该结算周期内会发生结算的交易总金额（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_fee")]
        public int PaymentFee { get; set; }

        /// <summary>
        /// 获取或设置该结算周期内退款总金额（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
        public int RefundFee { get; set; }

        /// <summary>
        /// 获取或设置该结算周期交易与退款总金额之差（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_net_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_net_fee")]
        public int NetFee { get; set; }

        /// <summary>
        /// 获取或设置手续费金额（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poundage_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("poundage_fee")]
        public int PoundageFee { get; set; }
    }
}
