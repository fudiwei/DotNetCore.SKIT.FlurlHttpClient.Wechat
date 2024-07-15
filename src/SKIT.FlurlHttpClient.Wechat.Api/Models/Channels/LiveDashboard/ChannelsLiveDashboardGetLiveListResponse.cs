namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/livedashboard/getlivelist 接口的响应。</para>
    /// </summary>
    public class ChannelsLiveDashboardGetLiveListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LiveItem
            {
                /// <summary>
                /// 获取或设置直播唯一 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_items")]
        [System.Text.Json.Serialization.JsonPropertyName("live_items")]
        public Types.LiveItem[] LiveItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置追踪 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string TraceId { get; set; } = default!;
    }
}
