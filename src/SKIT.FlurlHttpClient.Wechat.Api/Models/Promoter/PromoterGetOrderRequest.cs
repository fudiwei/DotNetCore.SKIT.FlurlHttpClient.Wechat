namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getorder 接口的请求。</para>
    /// </summary>
    public class PromoterGetOrderRequest : PublisherStatSettlementRequest, IInferable<PromoterGetOrderRequest, PromoterGetOrderResponse>
    {
        /// <summary>
        /// 获取或设置推广员的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string PromoterOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置订单支付日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? DateString { get; set; }

        /// <summary>
        /// 获取或设置分页起始 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_id")]
        [System.Text.Json.Serialization.JsonPropertyName("start_id")]
        public string? StartId { get; set; }

        /// <summary>
        /// 获取或设置是否返回 UnionID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_unionid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_unionid")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsReturnUnionId { get; set; }

    }
}
