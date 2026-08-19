namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/userbooking/list 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderUserBookingListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置预约类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("booking_type")]
                [System.Text.Json.Serialization.JsonPropertyName("booking_type")]
                public int BookingType { get; set; }

                /// <summary>
                /// 获取或设置原承诺发货时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("original_delivery_time")]
                public int OriginalDeliveryTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预约发货时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("booking_predict_time")]
                [System.Text.Json.Serialization.JsonPropertyName("booking_predict_time")]
                public int BookingPredictTimestamp { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public int OrderCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预约时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public int CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public int UpdateTimestamp { get; set; }
            }

            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页起始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int? Offset { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; }

                /// <summary>
                /// 获取或设置下一页翻页标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_key")]
                [System.Text.Json.Serialization.JsonPropertyName("next_key")]
                public string? NextCursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置预约记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("record_list")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置下一页分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_page")]
        [System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public Types.Pagination? NextPagination { get; set; }
    }
}
