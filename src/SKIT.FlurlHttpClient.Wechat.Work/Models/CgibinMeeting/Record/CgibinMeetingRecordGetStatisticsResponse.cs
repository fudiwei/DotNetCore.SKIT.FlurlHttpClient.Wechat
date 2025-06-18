namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/record/get_statistics 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRecordGetStatisticsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Summary
            {
                /// <summary>
                /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置观看次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_count")]
                [System.Text.Json.Serialization.JsonPropertyName("view_count")]
                public int ViewCount { get; set; }

                /// <summary>
                /// 获取或设置下载次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_count")]
                [System.Text.Json.Serialization.JsonPropertyName("download_count")]
                public int DownloadCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置统计列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summaries")]
        [System.Text.Json.Serialization.JsonPropertyName("summaries")]
        public Types.Summary[] SummaryList { get; set; } = default!;
    }
}
