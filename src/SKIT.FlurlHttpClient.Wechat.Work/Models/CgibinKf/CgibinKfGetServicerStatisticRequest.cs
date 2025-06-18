namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/get_servicer_statistic 接口的请求。</para>
    /// </summary>
    public class CgibinKfGetServicerStatisticRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
        public string? OpenKfId { get; set; }

        /// <summary>
        /// 获取或设置接待人员的 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("servicer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("servicer_userid")]
        public string? ServicerUserId { get; set; }

        /// <summary>
        /// 获取或设置起始日期的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束日期的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
