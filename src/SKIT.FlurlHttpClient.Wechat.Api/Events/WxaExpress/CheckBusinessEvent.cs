namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.check_biz 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/express/express-by-provider/onCheckBusiness.html </para>
    /// </summary>
    public class CheckBusinessEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizID")]
        [System.Text.Json.Serialization.JsonPropertyName("BizID")]
        [System.Xml.Serialization.XmlElement("BizID")]
        public string BusinessId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司客户密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizPwd")]
        [System.Text.Json.Serialization.JsonPropertyName("BizPwd")]
        [System.Xml.Serialization.XmlElement("BizPwd", IsNullable = true)]
        public string? BusinessPassword { get; set; }

        /// <summary>
        /// 获取或设置商户的小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShopAppID")]
        [System.Text.Json.Serialization.JsonPropertyName("ShopAppID")]
        [System.Xml.Serialization.XmlElement("ShopAppID", IsNullable = true)]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置商户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShopName")]
        [System.Text.Json.Serialization.JsonPropertyName("ShopName")]
        [System.Xml.Serialization.XmlElement("ShopName", IsNullable = true)]
        public string? ShopName { get; set; }

        /// <summary>
        /// 获取或设置商户联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShopTelphone")]
        [System.Text.Json.Serialization.JsonPropertyName("ShopTelphone")]
        [System.Xml.Serialization.XmlElement("ShopTelphone", IsNullable = true)]
        public string? ShopTeleNumber { get; set; }

        /// <summary>
        /// 获取或设置商户联系人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShopContact")]
        [System.Text.Json.Serialization.JsonPropertyName("ShopContact")]
        [System.Xml.Serialization.XmlElement("ShopContact", IsNullable = true)]
        public string? ShopContact { get; set; }

        /// <summary>
        /// 获取或设置预开通的服务类型名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ServiceName")]
        [System.Text.Json.Serialization.JsonPropertyName("ServiceName")]
        [System.Xml.Serialization.XmlElement("ServiceName", IsNullable = true)]
        public string? ServiceName { get; set; }

        /// <summary>
        /// 获取或设置商户发货省份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SenderProvince")]
        [System.Text.Json.Serialization.JsonPropertyName("SenderProvince")]
        [System.Xml.Serialization.XmlElement("SenderProvince", IsNullable = true)]
        public string? SenderProvince { get; set; }

        /// <summary>
        /// 获取或设置商户发货城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SenderCity")]
        [System.Text.Json.Serialization.JsonPropertyName("SenderCity")]
        [System.Xml.Serialization.XmlElement("SenderCity", IsNullable = true)]
        public string? SenderCity { get; set; }

        /// <summary>
        /// 获取或设置商户发货区县。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SenderArea")]
        [System.Text.Json.Serialization.JsonPropertyName("SenderArea")]
        [System.Xml.Serialization.XmlElement("SenderArea", IsNullable = true)]
        public string? SenderDistrict { get; set; }

        /// <summary>
        /// 获取或设置商户发货地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SenderAddress")]
        [System.Text.Json.Serialization.JsonPropertyName("SenderAddress")]
        [System.Xml.Serialization.XmlElement("SenderAddress", IsNullable = true)]
        public string? SenderAddress { get; set; }
    }
}
