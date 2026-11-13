namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getcdnlogs 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetCdnLogsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Log
            {
                /// <summary>
                /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string? DateString { get; set; }

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

                /// <summary>
                /// 获取或设置文件名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 CDN 日志列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domestic_cdn_logs")]
        [System.Text.Json.Serialization.JsonPropertyName("domestic_cdn_logs")]
        public List<Types.Log>? LogList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
