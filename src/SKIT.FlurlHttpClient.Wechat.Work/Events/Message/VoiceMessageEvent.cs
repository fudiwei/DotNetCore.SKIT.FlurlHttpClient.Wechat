namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 VOICE 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90239 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90375 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90855 ]]>
    /// </para>
    /// </summary>
    public class VoiceMessageEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置语音格式。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Format")]
        public string Format { get; set; } = default!;

        /// <summary>
        /// 获取或设置语音消息 MediaId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;
    }
}
