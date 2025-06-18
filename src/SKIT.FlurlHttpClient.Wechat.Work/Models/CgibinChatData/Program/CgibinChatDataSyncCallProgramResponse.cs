namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/sync_call_program 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataSyncCallProgramResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置专区程序的输出 JSON。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_data")]
        [System.Text.Json.Serialization.JsonPropertyName("response_data")]
        public string? ResponseDataJson { get; set; }
    }
}
