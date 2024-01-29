namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.card_merchant_check_result 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Third-party_developer_mode.html#2 </para>
    /// </summary>
    public class CardMerchantCheckResultEvent : CardPassCheckEvent
    {
        /// <summary>
        /// 获取或设置子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MerchantId")]
        [System.Text.Json.Serialization.JsonPropertyName("MerchantId")]
        [System.Xml.Serialization.XmlElement("MerchantId")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否通过。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsPass")]
        [System.Text.Json.Serialization.JsonPropertyName("IsPass")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsPass")]
        public bool IsPassed { get; set; }

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Reason")]
        [System.Text.Json.Serialization.JsonPropertyName("Reason")]
        [System.Xml.Serialization.XmlElement("Reason", IsNullable = true)]
        public string? RefuseReason { get; set; }
    }
}
