namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.change_editon 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/91933 </para>
    /// </summary>
    public class ChangeEditionEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置购买方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PaidCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("PaidCorpId")]
        [System.Xml.Serialization.XmlElement("PaidCorpId")]
        public string PayerCorpId { get; set; } = default!;
    }
}
