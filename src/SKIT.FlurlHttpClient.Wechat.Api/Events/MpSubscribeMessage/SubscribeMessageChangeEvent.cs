using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.subscribe_msg_change_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Subscription_Messages/api.html#%E4%BA%8B%E4%BB%B6%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class SubscribeMessageChangeEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
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
                        [System.Xml.Serialization.XmlElement("TemplateId")]
                        public string TemplateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户点击行为。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("SubscribeStatusString")]
                        public string SubscribeStatus { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置用户管理订阅通知数据列表。
                /// </summary>
                [System.Xml.Serialization.XmlArray("List")]
                public Types.EventItem[] EventList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SubscribeMsgChangeEvent")]
        public Types.Data EventData { get; set; } = default!;
    }
}
