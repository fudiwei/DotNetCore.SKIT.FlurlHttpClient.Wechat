﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.modify_calendar 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93651 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93704 </para>
    /// </summary>
    public class ModifyCalendarEvent : AddCalendarEvent, WechatWorkEvent.Serialization.IJsonSerializable, WechatWorkEvent.Serialization.IXmlSerializable
    {
    }
}
