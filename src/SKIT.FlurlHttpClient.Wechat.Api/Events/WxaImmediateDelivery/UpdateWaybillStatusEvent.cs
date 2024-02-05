namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.update_waybill_status 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.onOrderStatus.html ]]>
    /// </para>
    /// </summary>
    public class UpdateWaybillStatusEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Agent
            {
                /// <summary>
                /// 获取或设置骑手姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [System.Xml.Serialization.XmlElement("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置骑手电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [System.Xml.Serialization.XmlElement("phone")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置预计送达时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reach_time")]
                [System.Text.Json.Serialization.JsonPropertyName("reach_time")]
                [System.Xml.Serialization.XmlElement("reach_time")]
                public long? ReachTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        [System.Xml.Serialization.XmlElement("shopid")]
        public string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        [System.Xml.Serialization.XmlElement("shop_order_id")]
        public string ShopOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        [System.Xml.Serialization.XmlElement("shop_no")]
        public string ShopNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        [System.Xml.Serialization.XmlElement("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        [System.Xml.Serialization.XmlElement("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置状态变更时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_time")]
        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
        [System.Xml.Serialization.XmlElement("action_time")]
        public long ActionTimestamp { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
        [System.Xml.Serialization.XmlElement("action_msg", IsNullable = true)]
        public string? ActionMessage { get; set; }

        /// <summary>
        /// 获取或设置骑手信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent")]
        [System.Text.Json.Serialization.JsonPropertyName("agent")]
        [System.Xml.Serialization.XmlElement("agent", IsNullable = true)]
        public Types.Agent? Agent { get; set; }
    }
}
