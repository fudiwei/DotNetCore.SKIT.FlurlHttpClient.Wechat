namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.xpay_apple_subscribe_unsigning_result_notify 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/vip.html ]]>
    /// </para>
    /// </summary>
    public class XPayApplySubscribeUnsigningResultNotifyEvent : WechatApiEvent
    {
        public static class Types
        {
            public class AppleSubscriptionInfo : XPayApplySubscribeSigningResultNotifyEvent.Types.AppleSubscriptionInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenId")]
        [System.Xml.Serialization.XmlElement("OpenId")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置透传信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Attach")]
        [System.Text.Json.Serialization.JsonPropertyName("Attach")]
        [System.Xml.Serialization.XmlElement("Attach", IsNullable = true)]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置苹果订阅签约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppleSubscriptionInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("AppleSubscriptionInfo")]
        [System.Xml.Serialization.XmlElement("AppleSubscriptionInfo", IsNullable = true)]
        public Types.AppleSubscriptionInfo? AppleSubscriptionInfo { get; set; }
    }
}
