namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/order/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierOrderListGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierOrderListGetRequest, ChannelsECLeagueHeadSupplierOrderListGetResponse>
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
        }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string? FinderId { get; set; }

        /// <summary>
        /// 获取或设置创建时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_range")]
        public Types.TimeRange? CreateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_range")]
        public Types.TimeRange? UpdateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
