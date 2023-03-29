namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.head_supplier_item_update 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/callback/head_supplier_item_update.html </para>
    /// </summary>
    public class ChannelsECHeadSupplierItemUpdateEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置事件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event_type")]
                [System.Text.Json.Serialization.JsonPropertyName("event_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("event_type")]
                public int EventType { get; set; }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                [System.Xml.Serialization.XmlElement("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                [System.Xml.Serialization.XmlElement("version")]
                public string? Version { get; set; }

                /// <summary>
                /// 获取或设置商品变更字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_fields")]
                [System.Text.Json.Serialization.JsonPropertyName("update_fields")]
                [System.Xml.Serialization.XmlElement("update_fields", Type = typeof(string), IsNullable = true)]
                public string[]? UpdatedFieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_info")]
        [System.Text.Json.Serialization.JsonPropertyName("item_info")]
        [System.Xml.Serialization.XmlElement("item_info")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
