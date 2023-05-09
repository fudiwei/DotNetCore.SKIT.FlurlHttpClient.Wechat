namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/get_order_list 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderGetOrderListRequest : WechatApiRequest, IInferable<WxaSecOrderGetOrderListRequest, WxaSecOrderGetOrderListResponse>
    {
        public static class Types
        {
            public class TimeRange
            {
                /// <summary>
                /// 获取或设置起始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long? BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置支付时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time_range")]
        public Types.TimeRange? PagTimeRange { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_state")]
        [System.Text.Json.Serialization.JsonPropertyName("order_state")]
        public int? OrderState { get; set; }

        /// <summary>
        /// 获取或设置支付者的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_index")]
        [System.Text.Json.Serialization.JsonPropertyName("last_index")]
        public string? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? Limit { get; set; }
    }
}
