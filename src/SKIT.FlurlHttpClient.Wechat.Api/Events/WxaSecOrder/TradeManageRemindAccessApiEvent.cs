namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.trade_manage_remind_access_api 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html#%E4%B9%9D%E3%80%81%E7%9B%B8%E5%85%B3%E6%B6%88%E6%81%AF%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class TradeManageRemindAccessApiEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
        public string? Message { get; set; }
    }
}
