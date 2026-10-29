namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.card_not_pass_check" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Coupons_Vouchers_and_Cards_Event_Push_Messages.html ]]>
    /// </para>
    /// </summary>
    public class CardNotPassCheckEvent : CardPassCheckEvent
    {
        /// <summary>
        /// 获取或设置审核不通过原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RefuseReason")]
        [System.Text.Json.Serialization.JsonPropertyName("RefuseReason")]
        [System.Xml.Serialization.XmlElement("RefuseReason")]
        public string? RefuseReason { get; set; }
    }
}
