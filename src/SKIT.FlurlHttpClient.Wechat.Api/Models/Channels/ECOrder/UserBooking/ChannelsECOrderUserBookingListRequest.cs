using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/userbooking/list 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderUserBookingListRequest : WechatApiRequest, IInferable<ChannelsECOrderUserBookingListRequest, ChannelsECOrderUserBookingListResponse>
    {
        public static class Types
        {
            public class TimeRange : ChannelsECOrderListGetRequest.Types.TimeRange
            {
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
                /// <para>默认值：100</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; } = 100;

                /// <summary>
                /// 获取或设置翻页标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_key")]
                [System.Text.Json.Serialization.JsonPropertyName("next_key")]
                public string? Cursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置下单时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range_order_create")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range_order_create")]
        public Types.TimeRange? OrderCreateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置预约发货时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range_booking_predict")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range_booking_predict")]
        public Types.TimeRange? BookingPredictTimeRange { get; set; }

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<string>? OrderIdList { get; set; }

        /// <summary>
        /// 获取或设置预约类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booking_type")]
        [System.Text.Json.Serialization.JsonPropertyName("booking_type")]
        public int? BookingType { get; set; }

        /// <summary>
        /// 获取或设置分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_info")]
        [System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public Types.Pagination? Pagination { get; set; }
    }
}
