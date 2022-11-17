namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/living/get_watch_stat_v2 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolLivingGetWatchStatisticsV2Request : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("livingid")]
        [System.Text.Json.Serialization.JsonPropertyName("livingid")]
        public string LivingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? Cursor { get; set; }
    }
}
