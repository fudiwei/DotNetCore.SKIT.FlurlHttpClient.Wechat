namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/check_debug_mode 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataCheckDebugModeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置程序当前的调试模式状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("debug_mode_status")]
        [System.Text.Json.Serialization.JsonPropertyName("debug_mode_status")]
        public int DebugModeStatus { get; set; }
    }
}
