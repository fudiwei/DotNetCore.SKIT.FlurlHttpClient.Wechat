namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/create_customer_short_url 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingCreateCustomerShortUrlRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户自定义数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_data")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_data")]
        public string CustomData { get; set; } = string.Empty;
    }
}
