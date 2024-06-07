namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getorder 接口的响应。</para>
    /// </summary>
    public class PromoterGetOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : PromoterGetRelationResponse.Types.Relation
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_amount")]
                public int PaidAmount { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                public long PaidTimestamp { get; set; }

                /// <summary>
                /// 获取或设置退款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refunded_time")]
                [System.Text.Json.Serialization.JsonPropertyName("refunded_time")]
                public long? RefundedTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置下一页分页起始 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_id")]
        [System.Text.Json.Serialization.JsonPropertyName("start_id")]
        public string? NextStartId { get; set; }
    }
}
