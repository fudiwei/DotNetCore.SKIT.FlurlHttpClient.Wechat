namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 回调通知事件的基类。
    /// </summary>
    [System.Xml.Serialization.XmlRoot("xml")]
    public class WechatOpenAIEvent : ICommonWebhookEvent
    {
        /// <summary>
        /// 获取或设置 AppId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appid", IsNullable = true)]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("createtime", IsNullable = true)]
        public long? CreateTimestamp { get; set; }
    }
}
