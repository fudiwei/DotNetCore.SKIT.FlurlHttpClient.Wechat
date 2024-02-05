namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.create_auth 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90642 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90795 ]]>
    /// </para>
    /// </summary>
    public class CreateAuthEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCode")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCode")]
        [System.Xml.Serialization.XmlElement("AuthCode")]
        public string AuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置扫码或者授权链接中的自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("State")]
        [System.Text.Json.Serialization.JsonPropertyName("State")]
        [System.Xml.Serialization.XmlElement("State", IsNullable = true)]
        public string? State { get; set; }
    }
}
