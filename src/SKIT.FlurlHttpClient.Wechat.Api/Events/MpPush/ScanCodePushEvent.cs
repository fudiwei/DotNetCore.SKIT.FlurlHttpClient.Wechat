using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.scancode_push 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Custom_Menus/Custom_Menu_Push_Events.html#2 </para>
    /// </summary>
    public class ScanCodePushEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class ScanCode
            {
                /// <summary>
                /// 获取或设置扫描类型。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ScanType")]
                public string ScanType { get; set; } = default!;

                /// <summary>
                /// 获取或设置扫描结果。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ScanResult")]
                public string ScanResult { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件 Key，即自定义菜单接口中的 Key 值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置扫描信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ScanCodeInfo")]
        public Types.ScanCode ScanCode { get; set; } = default!;
    }
}
