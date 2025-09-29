namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.ewaybill_push_path 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/push_path.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/notify/merchant_callback/ewaybill_push_path.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/supplier/notify/merchant_callback/ewaybill_push_path.html ]]>
    /// </para>
    /// </summary>
    public class EWaybillPushPathEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Waybill
            {
                /// <summary>
                /// 获取或设置电子面单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                [System.Xml.Serialization.XmlElement("ewaybill_order_id")]
                public string EWaybillOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                [System.Xml.Serialization.XmlElement("waybill_id")]
                public string WaybillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置轨迹状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置轨迹描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                [System.Xml.Serialization.XmlElement("desc")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Xml.Serialization.XmlElement("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_info")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_info")]
        [System.Xml.Serialization.XmlElement("waybill_info")]
        public Types.Waybill Waybill { get; set; } = default!;
    }
}
