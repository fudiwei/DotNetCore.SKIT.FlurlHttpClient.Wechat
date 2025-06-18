namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.cancel_auth_account 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onCancelAuth.html ]]>
    /// </para>
    /// </summary>
    public class CancelAuthAccountEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        [System.Xml.Serialization.XmlElement("shopid")]
        public string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起授权的商户小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_appid")]
        [System.Xml.Serialization.XmlElement("wx_appid")]
        public string MiniProgramAppId { get; set; } = default!;
    }
}
