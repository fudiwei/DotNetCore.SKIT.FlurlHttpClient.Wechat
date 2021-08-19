using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.template_card_event 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90240 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90240 </para>
    /// </summary>
    public class TemplateCardPushEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class SelectItem
            {
                /// <summary>
                /// 获取或设置问题的 Key 值。
                /// </summary>
                [System.Xml.Serialization.XmlElement("QuestionKey")]
                public string QuestionKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置选项 ID 列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("OpitonIds", Type = typeof(string))]
                public string[] OptionIdList { get; set; } = default!;
            }

            public class SelectList
            {
                /// <summary>
                /// 获取或设置下拉框列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("SelectedItem", Type = typeof(SelectItem))]
                public SelectItem[]? Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TaskId")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板卡片类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("CardType")]
        public string CardType { get; set; } = default!;

        /// <summary>
        /// 获取或设置用于更新卡片接口的 Code。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ResponseCode")]
        public string ResponseCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户点击的按钮 Key 值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("EventKey", IsNullable = true)]
        public string? ButtonKey { get; set; }

        /// <summary>
        /// 获取或设置下拉框列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SelectList")]
        public Types.SelectList? SelectList { get; set; } = default!;
    }
}
