using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.add_schedule 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93651 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93704 </para>
    /// </summary>
    public class AddScheduleEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IJsonSerializable, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ScheduleId")]
        [System.Text.Json.Serialization.JsonPropertyName("ScheduleId")]
        [System.Xml.Serialization.XmlElement("ScheduleId")]
        public string ScheduleId { get; set; } = default!;

        /// <summary>
        /// 获取或设置日历 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CalId")]
        [System.Text.Json.Serialization.JsonPropertyName("CalId")]
        [System.Xml.Serialization.XmlElement("CalId")]
        public string CalendarId { get; set; } = default!;
    }
}
