namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "text" 回调通知应答的数据</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Passive_user_reply_message.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Passive_user_reply_message.html ]]>
    /// </para>
    /// </summary>
    public class TextMessageReply : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Content")]
        [System.Text.Json.Serialization.JsonPropertyName("Content")]
        [System.Xml.Serialization.XmlElement("Content")]
        public string? Content { get; set; }

        public TextMessageReply()
        {
            MessageType = "text";
            Event = null;
        }
    }
}
