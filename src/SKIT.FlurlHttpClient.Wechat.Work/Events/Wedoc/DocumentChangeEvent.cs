namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.doc_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97833 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97834 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97835 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/98095 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/98096 </para>
    /// </summary>
    public class DocumentChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置文档 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DocId")]
        [System.Text.Json.Serialization.JsonPropertyName("DocId")]
        [System.Xml.Serialization.XmlElement("DocId", Type = typeof(string), IsNullable = true)]
        public string[]? DocumentIdList { get; set; }

        /// <summary>
        /// 获取或设置收集表 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FormId")]
        [System.Text.Json.Serialization.JsonPropertyName("FormId")]
        [System.Xml.Serialization.XmlElement("FormId", Type = typeof(string), IsNullable = true)]
        public string[]? FormIdList { get; set; }
    }
}
