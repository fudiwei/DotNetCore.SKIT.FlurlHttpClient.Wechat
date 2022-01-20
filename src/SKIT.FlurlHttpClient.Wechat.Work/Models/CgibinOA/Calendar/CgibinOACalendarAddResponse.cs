namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/calendar/add 接口的响应。</para>
    /// </summary>
    public class CgibinOACalendarAddResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置日历 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cal_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
        public string CalendarId { get; set; } = default!;
    }
}
