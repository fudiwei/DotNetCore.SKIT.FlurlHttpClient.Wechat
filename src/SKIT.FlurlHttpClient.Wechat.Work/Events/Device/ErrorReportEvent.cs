using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.error_report 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90751 </para>
    /// </summary>
    public class ErrorReportEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DeviceSn")]
        public string DeviceSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备上报的错误码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ErrCode")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置设备上报的错误信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ErrMsg")]
        public string? ErrorMessage { get; set; }
    }
}
