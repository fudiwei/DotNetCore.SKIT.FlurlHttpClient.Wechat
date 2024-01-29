namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/queryflow 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityQueryFlowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Flow
            {
                /// <summary>
                /// 获取或设置流水类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_type")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                public int FlowType { get; set; }

                /// <summary>
                /// 获取或设置 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信门店编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
                public string StoreId { get; set; } = default!;

                /// <summary>
                /// 获取或设置充值订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PayOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
                public string? OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置运单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
                public string? BillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置运力 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_trans_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
                public string ServiceTransId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                public int PayAmount { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int? RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置扣除违约金（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deduct_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("deduct_amount")]
                public int? DeductAmount { get; set; }

                /// <summary>
                /// 获取或设置支付状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_status")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_status")]
                public string PayStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_status")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                public string? RefundStatus { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置退款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_time")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
                public long RefundTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效截止日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_deadline")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_deadline")]
                public long? ConsumeDeadlineTimestamp { get; set; }

                /// <summary>
                /// 获取或设置运单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_status")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_status")]
                public int? DeliveryStatus { get; set; }

                /// <summary>
                /// 获取或设置运单完成配送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_finished_time")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_finished_time")]
                public long? DeliveryFinishedTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置总支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_pay_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_pay_amt")]
        public int? TotalPayAmount { get; set; }

        /// <summary>
        /// 获取或设置总退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_refund_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_refund_amt")]
        public int? TotalRefundAmount { get; set; }

        /// <summary>
        /// 获取或设置总违约金（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_deduct_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_deduct_amt")]
        public int? TotalDeductAmount { get; set; }

        /// <summary>
        /// 获取或设置流水列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_list")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_list")]
        public Types.Flow[] FlowList { get; set; } = default!;

        /// <summary>
        /// 获取或设置流水总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
