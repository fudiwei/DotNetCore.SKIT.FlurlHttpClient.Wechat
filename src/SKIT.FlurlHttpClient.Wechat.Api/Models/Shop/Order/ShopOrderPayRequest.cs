using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/pay 接口的请求。</para>
    /// </summary>
    public class ShopOrderPayRequest : WechatApiRequest, IMapResponse<ShopOrderPayRequest, ShopOrderPayResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。与字段 <see cref="OutOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义订单号。与字段 <see cref="OrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string? OutOrderId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置操作备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("action_remark")]
        public string? ActionRemark { get; set; }

        /// <summary>
        /// 获取或设置支付交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置付款时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? PayTime { get; set; }
    }
}
