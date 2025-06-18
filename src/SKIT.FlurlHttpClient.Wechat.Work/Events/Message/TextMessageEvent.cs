namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 TEXT 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90239 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90375 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90855 ]]>
    /// </para>
    /// </summary>
    public class TextMessageEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Content")]
        [System.Text.Json.Serialization.JsonPropertyName("Content")]
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = default!;
    }
}
