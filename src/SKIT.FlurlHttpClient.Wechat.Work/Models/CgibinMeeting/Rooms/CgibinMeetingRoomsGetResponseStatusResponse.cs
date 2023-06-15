namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/get_response_status 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsGetResponseStatusResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置应答状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置最近一次应答时间字符串（格式：yyyy/MM/dd HH:mm:ss）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_time")]
        [System.Text.Json.Serialization.JsonPropertyName("response_time")]
        public string LastResponseTimeString { get; set; } = default!;
    }
}
