namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_request_id 接口的响应。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsRequestIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Request
            {
                /// <summary>
                /// 获取或设置留资请求 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_id")]
                [System.Text.Json.Serialization.JsonPropertyName("request_id")]
                public string RequestId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("live_start_time")]
                public long LiveStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_description")]
                [System.Text.Json.Serialization.JsonPropertyName("live_description")]
                public string LiveDescription { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置留资请求列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Request[] RequestList { get; set; } = default!;

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
