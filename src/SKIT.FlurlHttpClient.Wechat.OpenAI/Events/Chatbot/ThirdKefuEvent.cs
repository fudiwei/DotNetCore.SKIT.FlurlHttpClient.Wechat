namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Events
{
    /// <summary>
    /// <para>表示 "userEnter" 回调通知事件的数据。</para>
    /// <para>表示 "userQuit" 回调通知事件的数据。</para>
    /// <para>表示 "customerStuffEnter" 回调通知事件的数据。</para>
    /// <para>表示 "customerStuffQuit" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/thirdkefu/recivemsg.html ]]>
    /// </para>
    /// </summary>
    public class ThirdKefuEvent : WechatChatbotEvent
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置消息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("msg")]
                public string? Message { get; set; }
            }

            public class CustomerInfo
            {
                /// <summary>
                /// 获取或设置客服 OpenId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置客服昵称。
                /// </summary>
                [System.Xml.Serialization.XmlElement("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置客服头像 URL。
                /// </summary>
                [System.Xml.Serialization.XmlElement("avatar")]
                public string? AvatarUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置对话来源。
        /// </summary>
        [System.Xml.Serialization.XmlElement("from")]
        public string? From { get; set; }

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

        /// <summary>
        /// 获取或设置客服信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("customerInfo")]
        public Types.CustomerInfo? CustomerInfo { get; set; }
    }
}
