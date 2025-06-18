namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/set_receive_callback 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSetReceiveCallbackRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置应用关联的程序 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program_id")]
        [System.Text.Json.Serialization.JsonPropertyName("program_id")]
        public string ProgramId { get; set; } = string.Empty;
    }
}
