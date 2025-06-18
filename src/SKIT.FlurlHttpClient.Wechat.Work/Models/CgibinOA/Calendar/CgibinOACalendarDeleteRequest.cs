namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/calendar/del 接口的请求。</para>
    /// </summary>
    public class CgibinOACalendarDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置日历 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cal_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
        public string CalendarId { get; set; } = string.Empty;
    }
}
