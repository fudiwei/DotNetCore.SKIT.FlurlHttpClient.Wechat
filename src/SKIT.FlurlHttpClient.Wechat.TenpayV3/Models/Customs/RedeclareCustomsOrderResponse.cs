using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /customs/redeclare 接口的响应。</para>
    /// </summary>
    public class RedeclareCustomsOrderResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_no")]
        public string? SubOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_id")]
        public string? SubOrderId { get; set; }

        /// <summary>
        /// 获取或设置最后更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ModifyTime { get; set; }

        /// <summary>
        /// 获取或设置申报结果说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("explanation")]
        [System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }
    }
}
