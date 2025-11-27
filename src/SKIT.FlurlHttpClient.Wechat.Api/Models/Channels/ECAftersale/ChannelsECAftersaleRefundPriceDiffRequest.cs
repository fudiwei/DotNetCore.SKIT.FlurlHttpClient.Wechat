namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/refundpricediff 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleRefundPriceDiffRequest : WechatApiRequest, IInferable<ChannelsECAftersaleRefundPriceDiffRequest, ChannelsECAftersaleRefundPriceDiffResponse>
    {
        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
        public long SKUId { get; set; }

        /// <summary>
        /// 获取或设置售后退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置售后原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string ReasonType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置代发起售后补充说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }
    }
}
