namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复图片消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#1 </para>
    /// </summary>
    public class ImageMessageReply : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片 MediaId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置图片信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Image")]
        public Types.Image Image { get; set; } = new Types.Image();

        public ImageMessageReply()
        {
            Event = null;
            MessageType = "image";
        }
    }
}
