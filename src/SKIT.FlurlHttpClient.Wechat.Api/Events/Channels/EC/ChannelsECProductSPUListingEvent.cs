namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.product_spu_listing 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/callback/ProductSpuListing.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/locallife/api/callback1.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECProductSPUListingEvent : WechatApiEvent
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
                /// 获取或设置上下架状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置下架原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? Reason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ProductSpuListing")]
        [System.Text.Json.Serialization.JsonPropertyName("ProductSpuListing")]
        [System.Xml.Serialization.XmlElement("ProductSpuListing")]
        public Types.Product Product { get; set; } = default!;
    }
}
