namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/realcontrol/dismiss 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRealControlDismissRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否强制结束会议。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("force_dismiss")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("force_dismiss")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsForceDismiss { get; set; }

        /// <summary>
        /// 获取或设置是否回收会议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retrieve_code")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("retrieve_code")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsRetrieveCode { get; set; }
    }
}
