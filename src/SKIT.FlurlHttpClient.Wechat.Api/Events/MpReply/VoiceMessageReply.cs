namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复语音消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#2 </para>
    /// </summary>
    public class VoiceMessageReply : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Voice
            {
                /// <summary>
                /// 获取或设置语音 MediaId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置语音信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Voice")]
        public Types.Voice Voice { get; set; } = default!;

        public VoiceMessageReply()
        {
            MessageType = "voice";
            Event = null;
        }
    }
}
