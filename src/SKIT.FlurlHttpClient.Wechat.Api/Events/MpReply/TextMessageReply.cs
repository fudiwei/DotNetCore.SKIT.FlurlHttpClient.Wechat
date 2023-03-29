namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复文本消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#0 </para>
    /// </summary>
    public class TextMessageReply : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = default!;

        public TextMessageReply()
        {
            MessageType = "text";
            Event = null;
        }
    }
}
