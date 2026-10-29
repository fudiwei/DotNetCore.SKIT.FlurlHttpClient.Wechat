namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "image" 回调通知应答的数据</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Passive_user_reply_message.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Passive_user_reply_message.html ]]>
    /// </para>
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
                public string? MediaId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Image")]
        [System.Text.Json.Serialization.JsonPropertyName("Image")]
        [System.Xml.Serialization.XmlElement("Image")]
        public Types.Image? Image { get; set; }

        public ImageMessageReply()
        {
            MessageType = "image";
            Event = null;
        }
    }
}
