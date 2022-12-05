namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.modify_schedule 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93651 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93704 </para>
    /// </summary>
    public class ModifyScheduleEvent : AddScheduleEvent, WechatWorkEvent.Serialization.IJsonSerializable, WechatWorkEvent.Serialization.IXmlSerializable
    {
    }
}
