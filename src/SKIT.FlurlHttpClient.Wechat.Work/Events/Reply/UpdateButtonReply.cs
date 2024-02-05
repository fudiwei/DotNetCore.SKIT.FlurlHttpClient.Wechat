namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复更新点击用户的按钮点击文案消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90241#%E6%A8%A1%E6%9D%BF%E5%8D%A1%E7%89%87%E6%9B%B4%E6%96%B0%E6%B6%88%E6%81%AF ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90377#%E6%A8%A1%E6%9D%BF%E5%8D%A1%E7%89%87%E6%9B%B4%E6%96%B0%E6%B6%88%E6%81%AF ]]>
    /// </para>
    /// </summary>
    public class UpdateButtonReply : WechatWorkEvent
    {
        public static class Types
        {
            public class Button
            {
                /// <summary>
                /// 获取或设置替换文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ReplaceName")]
                [System.Text.Json.Serialization.JsonPropertyName("ReplaceName")]
                [System.Xml.Serialization.XmlElement("ReplaceName")]
                public string ReplacementText { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置按钮信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Button")]
        [System.Text.Json.Serialization.JsonPropertyName("Button")]
        [System.Xml.Serialization.XmlElement("Button")]
        public Types.Button Button { get; set; } = new Types.Button();

        public UpdateButtonReply()
        {
            Event = null;
            MessageType = "update_button";
        }
    }
}
