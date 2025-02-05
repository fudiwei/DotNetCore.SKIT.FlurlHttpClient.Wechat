namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/sync_call_program 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSyncCallProgramRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置应用关联的程序 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program_id")]
        [System.Text.Json.Serialization.JsonPropertyName("program_id")]
        public string ProgramId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置程序关联的能力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ability_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ability_id")]
        public string AbilityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置通知 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_id")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_id")]
        public string NotifyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求的输入 JSON。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_data")]
        [System.Text.Json.Serialization.JsonPropertyName("request_data")]
        public string? RequestDataJson { get; set; }
    }
}
