namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/set_log_level 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSetLogLevelRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置应用关联的程序 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program_id")]
        [System.Text.Json.Serialization.JsonPropertyName("program_id")]
        public string ProgramId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日志级别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_level")]
        [System.Text.Json.Serialization.JsonPropertyName("log_level")]
        public int LogLevel { get; set; }
    }
}
