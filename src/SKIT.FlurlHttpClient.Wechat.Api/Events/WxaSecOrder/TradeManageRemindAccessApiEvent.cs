namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.trade_manage_remind_access_api" 回调通知事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
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
