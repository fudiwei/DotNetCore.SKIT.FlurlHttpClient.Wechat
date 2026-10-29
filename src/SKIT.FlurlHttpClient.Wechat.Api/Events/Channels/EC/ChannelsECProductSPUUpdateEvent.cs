namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.product_spu_update" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/notify/product_callback/ProductSpuUpdate.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/dev_before/locallife/callback/product_related/Group_purchase_discount_update_callback.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECProductSPUUpdateEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Product
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
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("product_type")]
                public int ProductType { get; set; }

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ProductSpuUpdate")]
        [System.Text.Json.Serialization.JsonPropertyName("ProductSpuUpdate")]
        [System.Xml.Serialization.XmlElement("ProductSpuUpdate")]
        public Types.Product? Product { get; set; }
    }
}
