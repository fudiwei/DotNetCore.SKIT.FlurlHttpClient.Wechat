namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    /// <summary>
    /// 表示微信智能机器人 API 回调通知事件的基类。
    /// </summary>
    [Newtonsoft.Json.JsonObject]
    public class WechatWorkAIBotEvent : ICommonWebhookEvent
    {
        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string? MessageType { get; set; }
    }
}
