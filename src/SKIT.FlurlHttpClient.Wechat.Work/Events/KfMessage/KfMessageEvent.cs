namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 kf_msg_or_event 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94670 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94699 </para>
    /// </summary>
    public class KfMessageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置调用拉取消息的 Token。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Content")]
        public string Token { get; set; } = default!;
    }
}
