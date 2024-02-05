namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Events
{
    /// <summary>
    /// <para>表示 userEnter 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/thirdkefu/recivemsg.html ]]>
    /// </para>
    /// </summary>
    public class UserEnterEvent : WechatOpenAIEvent
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置消息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("msg")]
                public string Message { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置对话来源。
        /// </summary>
        [System.Xml.Serialization.XmlElement("from")]
        public string From { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [System.Xml.Serialization.XmlElement("content")]
        public Types.Content? Content { get; set; }

        /// <summary>
        /// 获取或设置客服接入状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("kfstate")]
        public int KfState { get; set; }

        /// <summary>
        /// 获取或设置渠道。
        /// </summary>
        [System.Xml.Serialization.XmlElement("channel")]
        public int Channel { get; set; }

        /// <summary>
        /// 获取或设置用户评价。
        /// </summary>
        [System.Xml.Serialization.XmlElement("assessment", IsNullable = true)]
        public int? Assessment { get; set; }
    }
}
