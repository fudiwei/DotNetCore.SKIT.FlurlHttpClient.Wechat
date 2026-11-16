namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/platformkf/getmchticketlist 接口的请求。</para>
    /// </summary>
    public class ChannelsECPlatformKfGetMerchantTicketListRequest : WechatApiRequest, IInferable<ChannelsECPlatformKfGetMerchantTicketListRequest, ChannelsECPlatformKfGetMerchantTicketListResponse>
    {
        /// <summary>
        /// 获取或设置工单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_ticket_id")]
        [System.Text.Json.Serialization.JsonPropertyName("search_ticket_id")]
        public string? TicketId { get; set; }

        /// <summary>
        /// 获取或设置工单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_state")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket_state")]
        public int? TicketState { get; set; }

        /// <summary>
        /// 获取或设置工单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_class_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket_class_type")]
        public int? TicketClassType { get; set; }

        /// <summary>
        /// 获取或设置查询起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("search_start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("search_end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_order_type")]
        public int? SortType { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start")]
        [System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Offset { get; set; }
    }
}
