namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.open_order 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91929 ]]>
    /// </para>
    /// </summary>
    public class OpenOrderEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置购买方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PaidCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("PaidCorpId")]
        [System.Xml.Serialization.XmlElement("PaidCorpId")]
        public string PayerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置操作员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OperatorId")]
        [System.Text.Json.Serialization.JsonPropertyName("OperatorId")]
        [System.Xml.Serialization.XmlElement("OperatorId", IsNullable = true)]
        public string? OperatorId { get; set; }
    }
}
