using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 LOCATION 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90239 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90375 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90855 </para>
    /// </summary>
    public class LocationMessageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置应用类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AppType", IsNullable = true)]
        public string? AppType { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置纬度坐标。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Location_X")]
        public double Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度坐标。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Location_Y")]
        public double Longitude { get; set; }

        /// <summary>
        /// 获取或设置地图缩放大小。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Scale")]
        public double Scale { get; set; }

        /// <summary>
        /// 获取或设置地理位置信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Label")]
        public string Label { get; set; } = default!;
    }
}
