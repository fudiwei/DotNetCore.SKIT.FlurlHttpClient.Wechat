namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/finderlive/get_finder_live_leads_data 接口的响应。</para>
    /// </summary>
    public class ChannelsFinderLiveGetFinderLeadsDataListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LeadsData
            {
                /// <summary>
                /// 获取或设置组件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("component_type")]
                [System.Text.Json.Serialization.JsonPropertyName("component_type")]
                public int ComponentType { get; set; }

                /// <summary>
                /// 获取或设置流量来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("traffic_type")]
                [System.Text.Json.Serialization.JsonPropertyName("traffic_type")]
                public int TrafficType { get; set; }

                /// <summary>
                /// 获取或设置留资条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leads_count")]
                [System.Text.Json.Serialization.JsonPropertyName("leads_count")]
                public int LeadsCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置留资数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.LeadsData[] LeadsDataList { get; set; } = default!;
    }
}
