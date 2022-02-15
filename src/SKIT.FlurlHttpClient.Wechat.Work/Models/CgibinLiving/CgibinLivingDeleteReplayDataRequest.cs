namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/delete_replay_data 接口的请求。</para>
    /// </summary>
    public class CgibinLivingDeleteReplayDataRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("livingid")]
        [System.Text.Json.Serialization.JsonPropertyName("livingid")]
        public string LivingId { get; set; } = string.Empty;
    }
}
