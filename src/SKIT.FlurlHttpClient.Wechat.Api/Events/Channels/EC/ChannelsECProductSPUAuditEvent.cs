namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.product_spu_audit" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/dev_before/locallife/callback/product_related/Group_purchase_discount_review_callback.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/notify/product_callback/ProductSpuAudit.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECProductSPUAuditEvent : WechatApiEvent
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

                /// <summary>
                /// 获取或设置审核原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? Reason { get; set; }

                /// <summary>
                /// 获取或设置审核信息 JSON 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                [System.Xml.Serialization.XmlElement("audit_info", IsNullable = true)]
                public string? AuditInfoJson { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ProductSpuAudit")]
        [System.Text.Json.Serialization.JsonPropertyName("ProductSpuAudit")]
        [System.Xml.Serialization.XmlElement("ProductSpuAudit")]
        public Types.Product? Product { get; set; }
    }
}
