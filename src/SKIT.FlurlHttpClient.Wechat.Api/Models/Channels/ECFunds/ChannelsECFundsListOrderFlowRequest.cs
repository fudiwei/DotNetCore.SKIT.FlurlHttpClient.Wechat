namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/listorderflow 接口的请求。</para>
    /// </summary>
    public class ChannelsECFundsListOrderFlowRequest : WechatApiRequest, IInferable<ChannelsECFundsListOrderFlowRequest, ChannelsECFundsListOrderFlowResponse>
    {
        public static class Types
        {
            public class TimeRange
            {
                /// <summary>
                /// 获取或设置起始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin")]
                [System.Text.Json.Serialization.JsonPropertyName("begin")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end")]
                [System.Text.Json.Serialization.JsonPropertyName("end")]
                public long EndTimestamp { get; set; }
            }

            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页每页数量。
                /// <para>默认值：10</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; }

                /// <summary>
                /// 获取或设置分页起始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int? Offset { get; set; }

                /// <summary>
                /// 获取或设置是否使用分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_page_ctx")]
                [System.Text.Json.Serialization.JsonPropertyName("use_page_ctx")]
                public bool? UseCursor { get; set; }

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_ctx")]
                [System.Text.Json.Serialization.JsonPropertyName("page_ctx")]
                public string? Cursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单结算状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_settle_state")]
        [System.Text.Json.Serialization.JsonPropertyName("order_settle_state")]
        public int? OrderSettleState { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_state")]
        [System.Text.Json.Serialization.JsonPropertyName("order_state")]
        public int? OrderState { get; set; }

        /// <summary>
        /// 获取或设置订单支付方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_pay_method")]
        [System.Text.Json.Serialization.JsonPropertyName("order_pay_method")]
        public int? OrderPayMethod { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置订单创建时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_create_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("order_create_time_range")]
        public Types.TimeRange? OrderCreateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pagination_info")]
        [System.Text.Json.Serialization.JsonPropertyName("pagination_info")]
        public Types.Pagination? PaginationInfo { get; set; }
    }
}
