namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_component_promote_record 接口的响应。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsComponentPromoteRecordResponse : WechatApiResponse
    {
        public static class Types
        {
            public class RecordData
            {
                /// <summary>
                /// 获取或设置主播昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("anchor_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("anchor_nickname")]
                public string AnchorNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_description")]
                [System.Text.Json.Serialization.JsonPropertyName("live_description")]
                public string LiveDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("live_start_time")]
                public long LiveStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置曝光 UV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exposure_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("exposure_uv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ExposureUV { get; set; }

                /// <summary>
                /// 获取或设置点击 UV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("click_uv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ClickUV { get; set; }

                /// <summary>
                /// 获取或设置曝光点击率。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exposure_click_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("exposure_click_rate")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal ExposureClickRate { get; set; }

                /// <summary>
                /// 获取或设置留资人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leads_num")]
                [System.Text.Json.Serialization.JsonPropertyName("leads_num")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int LeadsNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推广记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_data")]
        [System.Text.Json.Serialization.JsonPropertyName("record_data")]
        public Types.RecordData[] RecordDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? NextCursor { get; set; }
    }
}
