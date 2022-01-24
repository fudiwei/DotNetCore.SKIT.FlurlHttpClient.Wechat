namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/contractorder 接口的响应。</para>
    /// </summary>
    public class CreateContractOrderResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// 获取或设置预签约结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_result_code")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_result_code")]
        public string? ContractResultCode { get; set; }

        /// <summary>
        /// 获取或设置预签约错误代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_err_code")]
        public string? ContractErrorCode { get; set; }

        /// <summary>
        /// 获取或设置预签约错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_err_code_des")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_err_code_des")]
        public string? ContractErrorCodeDescription { get; set; }

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
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置预支付交易会话标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; } = default!;

        /// <summary>
        /// 获取或设置二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_url")]
        [System.Text.Json.Serialization.JsonPropertyName("code_url")]
        public string? CodeUrl { get; set; }

        /// <summary>
        /// 获取或设置支付跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mweb_url")]
        [System.Text.Json.Serialization.JsonPropertyName("mweb_url")]
        public string? MobileWebUrl { get; set; }

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? PlanId { get; set; }

        /// <summary>
        /// 获取或设置签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_code")]
        public string? ContractCode { get; set; }

        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? RequestSerialNumber { get; set; }

        /// <summary>
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_display_account")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_display_account")]
        public string? ContractDisplayAccount { get; set; }
    }
}
