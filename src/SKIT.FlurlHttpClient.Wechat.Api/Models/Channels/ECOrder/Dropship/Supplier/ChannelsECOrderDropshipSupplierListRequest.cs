namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/supplier/list 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDropshipSupplierListRequest : WechatApiRequest, IInferable<ChannelsECOrderDropshipSupplierListRequest, ChannelsECOrderDropshipSupplierListResponse>
    {
        public static class Types
        {
            public class TimeRange
            {
                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }
            }

            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页起始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int Offset { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置创建时间范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_range")]
        public Types.TimeRange? CreateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置商家小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置代发单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_info")]
        [System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public Types.Pagination? Pagination { get; set; }
    }
}
