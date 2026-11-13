namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/set_compat_sync 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotSetCompatSyncRequest : WechatWorkAIBotRequest
    {
        /// <summary>
        /// 获取或设置是否停止群聊通道同步。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_compat_from_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("stop_compat_from_channel")]
        public bool IsStopCompatFromChannel { get; set; }
    }
}
