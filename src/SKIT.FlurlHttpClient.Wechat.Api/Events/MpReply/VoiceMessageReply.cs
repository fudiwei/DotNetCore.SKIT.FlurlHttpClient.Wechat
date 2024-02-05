namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复语音消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#2 ]]>
    /// </para>
    /// </summary>
    public class VoiceMessageReply : WechatApiEvent
    {
        public static class Types
        {
            public class Voice
            {
                /// <summary>
                /// 获取或设置语音 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MediaId")]
                [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置语音信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Voice")]
        [System.Text.Json.Serialization.JsonPropertyName("Voice")]
        [System.Xml.Serialization.XmlElement("Voice")]
        public Types.Voice Voice { get; set; } = default!;

        public VoiceMessageReply()
        {
            MessageType = "voice";
            Event = null;
        }
    }
}
