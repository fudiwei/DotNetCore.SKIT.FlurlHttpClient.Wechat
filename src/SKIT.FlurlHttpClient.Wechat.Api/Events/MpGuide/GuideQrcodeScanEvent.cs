using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.guide_qrcode_scan_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Shopping_Guide/guide-account/shopping-guide.onGuideCreateQrCode.html </para>
    /// </summary>
    public class GuideQrcodeScanEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置顾问微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_guide_account")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_guide_account")]
                [System.Xml.Serialization.XmlElement("qrcode_guide_account")]
                public string GuideAccount { get; set; } = default!;

                /// <summary>
                /// 获取或设置顾问 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_guide_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_guide_openid")]
                [System.Xml.Serialization.XmlElement("qrcode_guide_openid", IsNullable = true)]
                public string? GuideOpenId { get; set; }

                /// <summary>
                /// 获取或设置扫码用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                [System.Xml.Serialization.XmlElement("openid")]
                public string BuyerOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置扫码类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action")]
                [System.Text.Json.Serialization.JsonPropertyName("action")]
                [System.Xml.Serialization.XmlElement("action")]
                public int Action { get; set; }

                /// <summary>
                /// 获取或设置生成二维码时的扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_info")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_info")]
                [System.Xml.Serialization.XmlElement("qrcode_info", IsNullable = true)]
                public string? QrcodeExt { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("GuideScanEvent")]
        [System.Text.Json.Serialization.JsonPropertyName("GuideScanEvent")]
        [System.Xml.Serialization.XmlElement("GuideScanEvent")]
        public Types.Data EventData { get; set; } = default!;
    }
}
