namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.cooperation_shop_order 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/cooperation_shop/order_callback.html ]]>
    /// </para>
    /// </summary>
    public class CooperationShopOrderEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置店铺 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                [System.Xml.Serialization.XmlElement("shop_appid")]
                public string ShopAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Xml.Serialization.XmlElement("order_id")]
                public string OrderId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventData")]
        [System.Text.Json.Serialization.JsonPropertyName("EventData")]
        [System.Xml.Serialization.XmlElement("EventData")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
