namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.query_single_waybill_fee 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html ]]>
    /// </para>
    /// </summary>
    public class QuerySingleWaybillFeeEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Sender
            {
                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Name")]
                [System.Text.Json.Serialization.JsonPropertyName("Name")]
                [System.Xml.Serialization.XmlElement("Name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置座机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Tel")]
                [System.Text.Json.Serialization.JsonPropertyName("Tel")]
                [System.Xml.Serialization.XmlElement("Tel", IsNullable = true)]
                public string? TelephoneNumber { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("Mobile")]
                [System.Xml.Serialization.XmlElement("Mobile", IsNullable = true)]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Province")]
                [System.Text.Json.Serialization.JsonPropertyName("Province")]
                [System.Xml.Serialization.XmlElement("Province")]
                public string Province { get; set; } = default!;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("City")]
                [System.Text.Json.Serialization.JsonPropertyName("City")]
                [System.Xml.Serialization.XmlElement("City")]
                public string City { get; set; } = default!;

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Area")]
                [System.Text.Json.Serialization.JsonPropertyName("Area")]
                [System.Xml.Serialization.XmlElement("Area")]
                public string District { get; set; } = default!;

                /// <summary>
                /// 获取或设置街道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Street")]
                [System.Text.Json.Serialization.JsonPropertyName("Street")]
                [System.Xml.Serialization.XmlElement("Street")]
                public string Street { get; set; } = default!;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Address")]
                [System.Text.Json.Serialization.JsonPropertyName("Address")]
                [System.Xml.Serialization.XmlElement("Address")]
                public string Address { get; set; } = default!;

                /// <summary>
                /// 获取或设置地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Id")]
                [System.Text.Json.Serialization.JsonPropertyName("Id")]
                [System.Xml.Serialization.XmlElement("Id", IsNullable = true)]
                public string? AddressId { get; set; }
            }

            public class Receiver : Sender
            {
            }

            public class Cargo
            {
                /// <summary>
                /// 获取或设置物品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Special")]
                [System.Text.Json.Serialization.JsonPropertyName("Special")]
                [System.Xml.Serialization.XmlElement("Special", IsNullable = true)]
                public int? SpecialType { get; set; }

                /// <summary>
                /// 获取或设置包裹重量（单位：千克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Weight")]
                [System.Text.Json.Serialization.JsonPropertyName("Weight")]
                [System.Xml.Serialization.XmlElement("Weight", IsNullable = true)]
                public decimal? Weight { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Sender")]
        [System.Text.Json.Serialization.JsonPropertyName("Sender")]
        [System.Xml.Serialization.XmlElement("Sender")]
        public Types.Sender Sender { get; set; } = default!;

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("Receiver")]
        [System.Xml.Serialization.XmlElement("Receiver")]
        public Types.Receiver Receiver { get; set; } = default!;

        /// <summary>
        /// 获取或设置包裹信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("GoodDetail")]
        [System.Text.Json.Serialization.JsonPropertyName("GoodDetail")]
        [System.Xml.Serialization.XmlElement("GoodDetail", Type = typeof(Types.Cargo))]
        public Types.Cargo? Cargo { get; set; }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Scene")]
        [System.Text.Json.Serialization.JsonPropertyName("Scene")]
        [System.Xml.Serialization.XmlElement("Scene")]
        public int Scene { get; set; }
    }
}
