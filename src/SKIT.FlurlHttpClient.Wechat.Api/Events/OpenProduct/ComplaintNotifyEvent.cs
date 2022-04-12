namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.aftersale_user_cancel 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/complaint_order.html </para>
    /// </summary>
    public class ComplaintNotifyEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class ComplaintOrder
            {
                /// <summary>
                /// 获取或设置纠纷单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_order_id")]
                [System.Xml.Serialization.XmlElement("complaint_order_id")]
                public long ComplaintOrderId { get; set; }

                /// <summary>
                /// 获取或设置纠纷状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                [System.Xml.Serialization.XmlElement("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置纠纷处理事件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                [System.Xml.Serialization.XmlElement("event")]
                public int Event { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置纠纷单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_info")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_info")]
        [System.Xml.Serialization.XmlElement("complaint_info")]
        public Types.ComplaintOrder ComplaintOrder { get; set; } = default!;
    }
}
