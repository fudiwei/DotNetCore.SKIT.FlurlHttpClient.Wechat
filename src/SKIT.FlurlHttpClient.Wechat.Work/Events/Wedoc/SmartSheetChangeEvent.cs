namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.doc_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100986 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100987 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101016 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101017 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101018 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101019 ]]>
    /// </para>
    /// </summary>
    public class SmartSheetChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DocId")]
        [System.Text.Json.Serialization.JsonPropertyName("DocId")]
        [System.Xml.Serialization.XmlElement("DocId", IsNullable = true)]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 获取或设置子表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SheetId")]
        [System.Text.Json.Serialization.JsonPropertyName("SheetId")]
        [System.Xml.Serialization.XmlElement("SheetId", IsNullable = true)]
        public string? SheetId { get; set; }

        /// <summary>
        /// 获取或设置字段 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FieldId")]
        [System.Text.Json.Serialization.JsonPropertyName("FieldId")]
        [System.Xml.Serialization.XmlElement("FieldId", Type = typeof(string), IsNullable = true)]
        public string[]? FieldIdList { get; set; }

        /// <summary>
        /// 获取或设置记录 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RecordId")]
        [System.Text.Json.Serialization.JsonPropertyName("RecordId")]
        [System.Xml.Serialization.XmlElement("RecordId", Type = typeof(string), IsNullable = true)]
        public string[]? RecordIdList { get; set; }
    }
}
