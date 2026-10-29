namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.card_sku_remind" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Coupons_Vouchers_and_Cards_Event_Push_Messages.html ]]>
    /// </para>
    /// </summary>
    public class CardSKURemindEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CardId")]
        [System.Text.Json.Serialization.JsonPropertyName("CardId")]
        [System.Xml.Serialization.XmlElement("CardId")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置报警详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Detail")]
        [System.Text.Json.Serialization.JsonPropertyName("Detail")]
        [System.Xml.Serialization.XmlElement("Detail")]
        public string? Detail { get; set; }
    }
}
