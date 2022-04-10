namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/get_sharer_live_summary_list 接口的响应。</para>
    /// </summary>
    public class ShopSharerGetSharerLiveSummaryListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Live
            {
                /// <summary>
                /// 获取或设置直播间 ExportId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("live_export_id")]
                public string LiveExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播间昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("live_nickname")]
                public string LiveNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("live_start_time")]
                public long LiveStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("live_end_time")]
                public long LiveEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_status")]
                [System.Text.Json.Serialization.JsonPropertyName("live_status")]
                public int LiveStatus { get; set; }

                /// <summary>
                /// 获取或设置分享员有效带货额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("gmv")]
                public int GMV { get; set; }

                /// <summary>
                /// 获取或设置订单数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("order_cnt")]
                public int OrderCount { get; set; }

                /// <summary>
                /// 获取或设置下单用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("user_cnt")]
                public int UserCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lives")]
        [System.Text.Json.Serialization.JsonPropertyName("lives")]
        public Types.Live[] LiveList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
