namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/getpayorderlist 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightGetPayOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PayOrder
            {
                /// <summary>
                /// 获取或设置充值订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置充值金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_price")]
                [System.Text.Json.Serialization.JsonPropertyName("total_price")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否可以退款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_refund")]
                [System.Text.Json.Serialization.JsonPropertyName("can_refund")]
                public bool CanRefund { get; set; }

                /// <summary>
                /// 获取或设置退款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_time")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
                public long? RefundTimestamp { get; set; }

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_status")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                public int? RefundStatus { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amt")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amt")]
                public int? RefundAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置充值订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.PayOrder[] PayOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
