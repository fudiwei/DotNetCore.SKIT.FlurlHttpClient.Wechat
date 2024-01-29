namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.add_single_waybill 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html </para>
    /// </summary>
    public class AddSingleWaybillEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Sender : QuerySingleWaybillFeeEvent.Types.Sender
            {
            }

            public class Receiver : QuerySingleWaybillFeeEvent.Types.Receiver
            {
            }

            public class Cargo : QuerySingleWaybillFeeEvent.Types.Cargo
            {
            }

            public class Insurance : AddWaybillEvent.Types.Insurance
            {
            }
        }

        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Token")]
        [System.Text.Json.Serialization.JsonPropertyName("Token")]
        [System.Xml.Serialization.XmlElement("Token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WXAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("WXAppId")]
        [System.Xml.Serialization.XmlElement("WXAppId")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置大客户公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CompanyID")]
        [System.Text.Json.Serialization.JsonPropertyName("CompanyID")]
        [System.Xml.Serialization.XmlElement("CompanyID", IsNullable = true)]
        public string? CompanyId { get; set; }

        /// <summary>
        /// 获取或设置月结帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Account")]
        [System.Text.Json.Serialization.JsonPropertyName("Account")]
        [System.Xml.Serialization.XmlElement("Account", IsNullable = true)]
        public string? Account { get; set; }

        /// <summary>
        /// 获取或设置月结帐号密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AccountPwd")]
        [System.Text.Json.Serialization.JsonPropertyName("AccountPwd")]
        [System.Xml.Serialization.XmlElement("AccountPwd", IsNullable = true)]
        public string? AccountPassword { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderID")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderID")]
        [System.Xml.Serialization.XmlElement("OrderID", IsNullable = true)]
        public string? OrderId { get; set; }

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
        /// 获取或设置保价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Insured")]
        [System.Text.Json.Serialization.JsonPropertyName("Insured")]
        [System.Xml.Serialization.XmlElement("Insured", IsNullable = true)]
        public Types.Insurance? Insurance { get; set; }

        /// <summary>
        /// 获取或设置快递备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Remark")]
        [System.Text.Json.Serialization.JsonPropertyName("Remark")]
        [System.Xml.Serialization.XmlElement("Remark", IsNullable = true)]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置结算方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Settingment")]
        [System.Text.Json.Serialization.JsonPropertyName("Settingment")]
        [System.Xml.Serialization.XmlElement("Settingment", IsNullable = true)]
        public int? SettlementType { get; set; }

        /// <summary>
        /// 获取或设置期望上门取件起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExpectStartTime")]
        [System.Text.Json.Serialization.JsonPropertyName("ExpectStartTime")]
        [System.Xml.Serialization.XmlElement("ExpectStartTime", IsNullable = true)]
        public long? ExpectedStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置期望上门取件结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExpectEndTime")]
        [System.Text.Json.Serialization.JsonPropertyName("ExpectEndTime")]
        [System.Xml.Serialization.XmlElement("ExpectEndTime", IsNullable = true)]
        public long? ExpectedEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置上门时间段开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PickUpStartTime")]
        [System.Text.Json.Serialization.JsonPropertyName("PickUpStartTime")]
        [System.Xml.Serialization.XmlElement("PickUpStartTime", IsNullable = true)]
        public long? PickUpStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置上门时间段结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PickUpEndTime")]
        [System.Text.Json.Serialization.JsonPropertyName("PickUpEndTime")]
        [System.Xml.Serialization.XmlElement("PickUpEndTime", IsNullable = true)]
        public long? PickUpEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Scene")]
        [System.Text.Json.Serialization.JsonPropertyName("Scene")]
        [System.Xml.Serialization.XmlElement("Scene")]
        public int? Scene { get; set; }
    }
}
