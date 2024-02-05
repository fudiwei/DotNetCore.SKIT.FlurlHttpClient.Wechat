namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.get_quota 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/express/express-by-provider/onGetQuota.html ]]>
    /// </para>
    /// </summary>
    public class GetQuotaEvent : WechatApiEvent
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
    }
}
