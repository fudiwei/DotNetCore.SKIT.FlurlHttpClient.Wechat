namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复文本消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90241#%E6%96%87%E6%9C%AC%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90377#%E6%96%87%E6%9C%AC%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90859#%E6%96%87%E6%9C%AC%E6%B6%88%E6%81%AF ]]>
    /// </para>
    /// </summary>
    public class TextMessageReply : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Content")]
        [System.Text.Json.Serialization.JsonPropertyName("Content")]
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = string.Empty;

        public TextMessageReply()
        {
            Event = null;
            MessageType = "text";
        }
    }
}
