namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复图片消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#1 </para>
    /// </summary>
    public class ImageMessageReply : WechatApiEvent
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MediaId")]
                [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
                [System.Xml.Serialization.XmlElement("MediaId")]
                public string MediaId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Image")]
        [System.Text.Json.Serialization.JsonPropertyName("Image")]
        [System.Xml.Serialization.XmlElement("Image")]
        public Types.Image Image { get; set; } = default!;

        public ImageMessageReply()
        {
            MessageType = "image";
            Event = null;
        }
    }
}
