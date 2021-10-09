using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.del_device 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90751 </para>
    /// </summary>
    public class DeleteDeviceEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;
    }
}
