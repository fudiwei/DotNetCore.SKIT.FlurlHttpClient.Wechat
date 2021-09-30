namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/service_state/trans 接口的响应。</para>
    /// </summary>
    public class CgibinKfServiceStateTransferResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置用于发送响应事件消息的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_code")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_code")]
        public string MessageCode { get; set; } = default!;
    }
}
