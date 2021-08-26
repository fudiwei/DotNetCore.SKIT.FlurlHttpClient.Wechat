using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.LOCATION 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html#%E4%B8%8A%E6%8A%A5%E5%9C%B0%E7%90%86%E4%BD%8D%E7%BD%AE%E4%BA%8B%E4%BB%B6 </para>
    /// </summary>
    public class LocationPushEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置地理位置纬度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Latitude")]
        [System.Text.Json.Serialization.JsonPropertyName("Latitude")]
        [System.Xml.Serialization.XmlElement("Latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 获取或设置地理位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Longitude")]
        [System.Text.Json.Serialization.JsonPropertyName("Longitude")]
        [System.Xml.Serialization.XmlElement("Longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 获取或设置地理位置精度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Precision")]
        [System.Text.Json.Serialization.JsonPropertyName("Precision")]
        [System.Xml.Serialization.XmlElement("Precision")]
        public double Precision { get; set; }
    }
}
