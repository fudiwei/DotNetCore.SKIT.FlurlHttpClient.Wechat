using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_brand_audit 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/ministore/minishopopencomponent2/callback/brand_audit.html </para>
    /// </summary>
    public class OpenProductBrandAuditEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class EventData : OpenProductCategoryAuditEvent.Types.EventData
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Xml.Serialization.XmlElement("brand_id")]
                public int BrandId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("QualificationAuditResult")]
        [System.Text.Json.Serialization.JsonPropertyName("QualificationAuditResult")]
        [System.Xml.Serialization.XmlElement("QualificationAuditResult")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
