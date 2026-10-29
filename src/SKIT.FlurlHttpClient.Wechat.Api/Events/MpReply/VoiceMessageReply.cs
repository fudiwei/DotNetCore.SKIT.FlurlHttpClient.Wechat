namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "voice" 回调通知应答的数据</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Passive_user_reply_message.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Passive_user_reply_message.html ]]>
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
                public string? MediaId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置语音信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Voice")]
        [System.Text.Json.Serialization.JsonPropertyName("Voice")]
        [System.Xml.Serialization.XmlElement("Voice")]
        public Types.Voice? Voice { get; set; }

        public VoiceMessageReply()
        {
            MessageType = "voice";
            Event = null;
        }
    }
}
