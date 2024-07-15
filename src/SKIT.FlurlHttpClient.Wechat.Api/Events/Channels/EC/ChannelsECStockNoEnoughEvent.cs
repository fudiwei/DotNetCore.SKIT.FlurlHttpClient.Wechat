namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_stock_no_enough 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/callback_inventory.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECStockNoEnoughEvent : WechatApiEvent
    {
        public static class Types
        {
            public class StockInfo
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("sku_id")]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置剩余库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remaining_stock_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("remaining_stock_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("remaining_stock_amount")]
                public int RemainingStockAmount { get; set; }

                /// <summary>
                /// 获取或设置剩余预存券码数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remaining_code_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("remaining_code_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("remaining_code_amount")]
                public int RemainingCodeAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置库存信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channels_ec_stock_no_enough")]
        [System.Text.Json.Serialization.JsonPropertyName("channels_ec_stock_no_enough")]
        [System.Xml.Serialization.XmlElement("channels_ec_stock_no_enough")]
        public Types.StockInfo StockInfo { get; set; } = default!;
    }
}
