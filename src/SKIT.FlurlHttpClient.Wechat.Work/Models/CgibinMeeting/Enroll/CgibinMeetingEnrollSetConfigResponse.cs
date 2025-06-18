namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/set_config 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingEnrollSetConfigResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置报名问题数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_count")]
        [System.Text.Json.Serialization.JsonPropertyName("question_count")]
        public int QuestionCount { get; set; }
    }
}
