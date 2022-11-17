namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.upload_media_job_finish 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/96219 </para>
    /// </summary>
    public class UploadMediaJobFinishEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("JobId")]
        public string JobId { get; set; } = default!;
    }
}
