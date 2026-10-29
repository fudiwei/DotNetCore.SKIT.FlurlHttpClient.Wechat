namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.subscribe_msg_sent_event" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/subscription_messages/push.html ]]>
    /// </para>
    /// </summary>
    public class SubscribeMessageSentEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                public static class Types
                {
                    public class EventItem
                    {
                        /// <summary>
                        /// 获取或设置订阅消息模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("TemplateId")]
                        [System.Text.Json.Serialization.JsonPropertyName("TemplateId")]
                        [System.Xml.Serialization.XmlElement("TemplateId")]
                        public string? TemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置消息 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MsgID")]
                        [System.Text.Json.Serialization.JsonPropertyName("MsgID")]
                        [System.Xml.Serialization.XmlElement("MsgID")]
                        public long? MessageId { get; set; }

                        /// <summary>
                        /// 获取或设置推送结果状态码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ErrorCode")]
                        [System.Text.Json.Serialization.JsonPropertyName("ErrorCode")]
                        [System.Xml.Serialization.XmlElement("ErrorCode")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置推送结果状态含义。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ErrorStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("ErrorStatus")]
                        [System.Xml.Serialization.XmlElement("ErrorStatus")]
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发送订阅通知数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                [System.Xml.Serialization.XmlElement("List", typeof(Types.EventItem))]
                public List<Types.EventItem>? EventList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlElement("SubscribeMsgSentEvent")]
        public Types.EventData? EventData { get; set; }

        /// <summary>
        /// 获取或设置发送订阅通知数据列表。
        /// <para>等效于 <see cref="Types.EventData.EventList"/> </para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("List")]
        [System.Text.Json.Serialization.JsonPropertyName("List")]
        [System.Xml.Serialization.XmlIgnore]
        public List<Types.EventData.Types.EventItem>? EventDataList
        {
            get
            {
                return this.EventData?.EventList;
            }
            set
            {
                this.EventData ??= new Types.EventData();
                this.EventData.EventList = value!;
            }
        }
    }
}
