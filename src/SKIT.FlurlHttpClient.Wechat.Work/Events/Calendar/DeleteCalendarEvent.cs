using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.delete_calendar 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93651 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93704 </para>
    /// </summary>
    public class DeleteCalendarEvent : AddCalendarEvent, WechatWorkEvent.Types.IJsonSerializable, WechatWorkEvent.Types.IXmlSerializable
    {
    }
}
