namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.wedrive_file_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97975 </para>
    /// </summary>
    public class WedriveFileChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件 ID 列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FileId", Type = typeof(string))]
        public string[] FileIdList { get; set; } = default!;
    }
}
