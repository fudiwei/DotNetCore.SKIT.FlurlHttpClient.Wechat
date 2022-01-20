namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.create_auth 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90642 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90795 </para>
    /// </summary>
    public class CreateAuthEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCode")]
        public string AuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置扫码或者授权链接中的自定义参数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("State", IsNullable = true)]
        public string? State { get; set; }
    }
}
