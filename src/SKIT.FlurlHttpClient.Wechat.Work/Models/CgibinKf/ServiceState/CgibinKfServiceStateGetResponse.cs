namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/service_state/get 接口的响应。</para>
    /// </summary>
    public class CgibinKfServiceStateGetResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置会话状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_state")]
        [System.Text.Json.Serialization.JsonPropertyName("service_state")]
        public int ServiceState { get; set; } 

        /// <summary>
        /// 获取或设置接待人员的 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("servicer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("servicer_userid")]
        public string? ServicerUserId { get; set; }
    }
}
