namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.wedrive_file_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97975 ]]>
    /// </para>
    /// </summary>
    public class WedriveFileChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FileId")]
        [System.Text.Json.Serialization.JsonPropertyName("FileId")]
        [System.Xml.Serialization.XmlElement("FileId", Type = typeof(string))]
        public string[] FileIdList { get; set; } = default!;
    }
}
