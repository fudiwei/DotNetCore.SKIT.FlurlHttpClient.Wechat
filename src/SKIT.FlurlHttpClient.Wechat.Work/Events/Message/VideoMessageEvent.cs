namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 VIDEO 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90239 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90375 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90855 </para>
    /// </summary>
    public class VideoMessageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
        /// 获取或设置视频消息 MediaId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频消息缩略图 MediaId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ThumbMediaId")]
        public string ThumbnailMediaId { get; set; } = default!;
    }
}
