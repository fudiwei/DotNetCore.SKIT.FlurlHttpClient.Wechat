namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "music" 回调通知应答的数据</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Passive_user_reply_message.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Passive_user_reply_message.html ]]>
    /// </para>
    /// </summary>
    public class MusicMessageReply : WechatApiEvent
    {
        public static class Types
        {
            public class Music
            {
                /// <summary>
                /// 获取或设置音乐链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MusicUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("MusicUrl")]
                [System.Xml.Serialization.XmlElement("MusicUrl")]
                public string? MusicUrl { get; set; }

                /// <summary>
                /// 获取或设置高质量音乐链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("HQMusicUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("HQMusicUrl")]
                [System.Xml.Serialization.XmlElement("HQMusicUrl", IsNullable = true)]
                public string? HQMusicUrl { get; set; }

                /// <summary>
                /// 获取或设置音乐封面图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ThumbMediaId")]
                [System.Text.Json.Serialization.JsonPropertyName("ThumbMediaId")]
                [System.Xml.Serialization.XmlElement("ThumbMediaId")]
                public string? ThumbMediaId { get; set; }

                /// <summary>
                /// 获取或设置音乐标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Title")]
                [System.Text.Json.Serialization.JsonPropertyName("Title")]
                [System.Xml.Serialization.XmlElement("Title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置音乐描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Description")]
                [System.Text.Json.Serialization.JsonPropertyName("Description")]
                [System.Xml.Serialization.XmlElement("Description")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置音乐信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Music")]
        [System.Text.Json.Serialization.JsonPropertyName("Music")]
        [System.Xml.Serialization.XmlElement("Music")]
        public Types.Music? Music { get; set; }

        public MusicMessageReply()
        {
            MessageType = "music";
            Event = null;
        }
    }
}
