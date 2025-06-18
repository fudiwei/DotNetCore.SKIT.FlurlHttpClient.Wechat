namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getliveinfo?action=get_replay 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetLiveReplayResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LiveReplay
            {
                /// <summary>
                /// 获取或设置回放视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_url")]
                [System.Text.Json.Serialization.JsonPropertyName("media_url")]
                public string MediaUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置回放视频 URL 过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置回放视频创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置回放视频片段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_replay")]
        [System.Text.Json.Serialization.JsonPropertyName("live_replay")]
        public Types.LiveReplay[] LiveReplayList { get; set; } = default!;

        /// <summary>
        /// 获取或设置回放视频片段总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
