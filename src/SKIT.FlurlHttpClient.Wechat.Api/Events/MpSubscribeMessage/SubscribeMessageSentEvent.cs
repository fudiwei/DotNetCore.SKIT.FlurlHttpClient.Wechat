using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.subscribe_msg_sent_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#%E4%BA%8B%E4%BB%B6%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class SubscribeMessageSentEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Data
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
                        public string TemplateId { get; set; } = default!;

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
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置发送订阅通知数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("List")]
                [System.Text.Json.Serialization.JsonPropertyName("List")]
                [System.Xml.Serialization.XmlArray("List")]
                public Types.EventItem[] EventList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SubscribeMsgSentEvent")]
        [System.Text.Json.Serialization.JsonPropertyName("SubscribeMsgSentEvent")]
        [System.Xml.Serialization.XmlElement("SubscribeMsgSentEvent")]
        public Types.Data EventData { get; set; } = default!;
    }
}
