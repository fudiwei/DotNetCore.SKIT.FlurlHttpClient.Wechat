namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/open_debug_mode 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataOpenDebugModeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置应用关联的程序 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program_id")]
        [System.Text.Json.Serialization.JsonPropertyName("program_id")]
        public string ProgramId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置程序的调试凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("debug_token")]
        [System.Text.Json.Serialization.JsonPropertyName("debug_token")]
        public string DebugToken { get; set; } = string.Empty;
    }
}
