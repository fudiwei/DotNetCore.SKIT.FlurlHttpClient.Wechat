namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复视频消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#3 </para>
    /// </summary>
    public class VideoMessageReply : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Video
            {
                /// <summary>
                /// 获取或设置视频 MediaId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频描述。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Description")]
                public string Description { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置视频信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Video")]
        public Types.Video Video { get; set; } = new Types.Video();

        public VideoMessageReply()
        {
            Event = null;
            MessageType = "video";
        }
    }
}
