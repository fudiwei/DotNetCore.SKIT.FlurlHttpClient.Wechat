namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 LINK 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90239 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90375 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90855 </para>
    /// </summary>
    public class LinkMessageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
        /// 获取或设置标题。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转链接 URL。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置封面图片 URL。
        /// </summary>
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;
    }
}
