namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 agree_external_userid_migration 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/95327 </para>
    /// </summary>
    public class AgreeExternalUserIdMigrationEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable, WechatWorkEvent.Serialization.IJsonSerializable
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ServiceCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("ServiceCorpId")]
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;
    }
}
