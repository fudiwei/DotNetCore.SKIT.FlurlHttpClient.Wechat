namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.kf_account_auth_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97712 </para>
    /// </summary>
    public class KfAccountAuthChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置新增授权的客服账号 ID 列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthAddOpenKfId", Type = typeof(string), IsNullable = true)]
        public string[]? AuthAddedOpenKfId { get; set; }

        /// <summary>
        /// 获取或设置取消授权的客服账号 ID 列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthDelOpenKfId", Type = typeof(string), IsNullable = true)]
        public string[]? AuthDeletedOpenKfId { get; set; }
    }
}
