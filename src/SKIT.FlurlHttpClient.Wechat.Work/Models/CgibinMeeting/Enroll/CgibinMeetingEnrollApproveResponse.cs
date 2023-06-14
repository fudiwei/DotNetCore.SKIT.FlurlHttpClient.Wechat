namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/approve 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingEnrollApproveResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成功处理的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("handled_count")]
        [System.Text.Json.Serialization.JsonPropertyName("handled_count")]
        public int HandledCount { get; set; }
    }
}
