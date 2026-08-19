namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/start_download_order 接口的请求。</para>
    /// </summary>
    public class XPayStartDownloadOrderRequest : XPayRequestBase, IInferable<XPayStartDownloadOrderRequest, XPayStartDownloadOrderResponse>
    {
        /// <summary>
        /// 获取或设置起始日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_ds")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("begin_ds")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置截止日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_ds")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_ds")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int? OrderType { get; set; }

        /// <summary>
        /// 获取或设置订单信息搜索关键字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public string? OrderKeyword { get; set; }

        /// <summary>
        /// 获取或设置是否已发货。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_provided")]
        [System.Text.Json.Serialization.JsonPropertyName("is_provided")]
        public bool? IsProvided { get; set; }

        /// <summary>
        /// 获取或设置退款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_status")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
        public int? RefundStatus { get; set; }

        /// <summary>
        /// 获取或设置支付渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_channel")]
        public int? PayChannel { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/start_download_order";
        }
    }
}
