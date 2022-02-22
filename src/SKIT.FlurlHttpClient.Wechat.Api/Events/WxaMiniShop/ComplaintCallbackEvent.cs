namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.complaint_callback 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/complaint.html </para>
    /// </summary>
    public class ComplaintCallbackEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class ComplaintHistory
            {
                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                [System.Xml.Serialization.XmlElement("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                [System.Xml.Serialization.XmlElement("content", IsNullable = true)]
                public string? Content { get; set; }

                /// <summary>
                /// 获取或设置图片 MediaId 列表字符串（以逗号分隔）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
                [System.Xml.Serialization.XmlElement("media_id_list", IsNullable = true)]
                public string? MediaIdListString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlElement("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件通知类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_type")]
        [System.Text.Json.Serialization.JsonPropertyName("option_type")]
        [System.Xml.Serialization.XmlElement("option_type")]
        public string OptionType { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_order_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlElement("complaint_order_id")]
        public long ComplaintOrderId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        [System.Xml.Serialization.XmlElement("open_id")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉问题类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Xml.Serialization.XmlElement("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Xml.Serialization.XmlElement("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置用户手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
        [System.Xml.Serialization.XmlElement("phone_number")]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉材料内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_material_content")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_material_content")]
        [System.Xml.Serialization.XmlElement("customer_material_content", IsNullable = true)]
        public string? CustomerMaterialContent { get; set; }

        /// <summary>
        /// 获取或设置投诉材料图片 MediaId 列表字符串（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_material_media_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_material_media_id_list")]
        [System.Xml.Serialization.XmlElement("customer_material_media_id_list", IsNullable = true)]
        public string? CustomerMaterialMediaIdListString { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [System.Xml.Serialization.XmlElement("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        [System.Xml.Serialization.XmlElement("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
        [System.Xml.Serialization.XmlElement("product_name")]
        public string ProductName { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Xml.Serialization.XmlElement("pay_time")]
        public long PayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置交易金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cost")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [System.Xml.Serialization.XmlElement("total_cost")]
        public int TotalCost { get; set; }

        /// <summary>
        /// 获取或设置投诉发起时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Xml.Serialization.XmlElement("create_time")]
        public long ComplaintCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置投诉状态过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Xml.Serialization.XmlElement("expire_time")]
        public long ComplaintStatusExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置投诉进度列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("history")]
        [System.Text.Json.Serialization.JsonPropertyName("history")]
        [System.Xml.Serialization.XmlArrayItem("history", Type = typeof(Types.ComplaintHistory))]
        public Types.ComplaintHistory[] ComplaintHistoryList { get; set; } = default!;
    }
}
