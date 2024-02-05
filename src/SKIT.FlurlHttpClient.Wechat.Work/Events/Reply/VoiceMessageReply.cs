namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复语音消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90241#%E8%AF%AD%E9%9F%B3%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90377#%E8%AF%AD%E9%9F%B3%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90859#%E8%AF%AD%E9%9F%B3%E6%B6%88%E6%81%AF ]]>
    /// </para>
    /// </summary>
    public class VoiceMessageReply : WechatWorkEvent
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
                public string MediaId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置语音信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Voice")]
        [System.Text.Json.Serialization.JsonPropertyName("Voice")]
        [System.Xml.Serialization.XmlElement("Voice")]
        public Types.Voice Voice { get; set; } = new Types.Voice();

        public VoiceMessageReply()
        {
            Event = null;
            MessageType = "voice";
        }
    }
}
