namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复视频消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90241#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90377#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90859#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF ]]>
    /// </para>
    /// </summary>
    public class VideoMessageReply : WechatWorkEvent
    {
        public static class Types
        {
            public class Video
            {
                /// <summary>
                /// 获取或设置视频 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MediaId")]
                [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Title")]
                [System.Text.Json.Serialization.JsonPropertyName("Title")]
                [System.Xml.Serialization.XmlElement("Title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Description")]
                [System.Text.Json.Serialization.JsonPropertyName("Description")]
                [System.Xml.Serialization.XmlElement("Description")]
                public string Description { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置视频信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Video")]
        [System.Text.Json.Serialization.JsonPropertyName("Video")]
        [System.Xml.Serialization.XmlElement("Video")]
        public Types.Video Video { get; set; } = new Types.Video();

        public VideoMessageReply()
        {
            Event = null;
            MessageType = "video";
        }
    }
}
