using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.add_device 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90751 </para>
    /// </summary>
    public class AddDeviceEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备型号 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ModelId")]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备备注名称。
        /// </summary>
        [System.Xml.Serialization.XmlElement("RemarkName")]
        public string? RemarkName { get; set; }
    }
}
