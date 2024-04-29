namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_brand 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/callback/brand_event.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECBrandEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Brand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("brand_id")]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置审核单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("audit_id")]
                public long AuditId { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BrandEvent")]
        [System.Text.Json.Serialization.JsonPropertyName("BrandEvent")]
        [System.Xml.Serialization.XmlElement("BrandEvent")]
        public Types.Brand Brand { get; set; } = default!;
    }
}
