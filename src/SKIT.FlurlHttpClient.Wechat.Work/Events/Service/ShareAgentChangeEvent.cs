namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.share_agent_change 或 INFO.share_agent_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90240 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/93373 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90376 ]]>
    /// </para>
    /// </summary>
    public class ShareAgentChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置上级企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("CorpId")]
        [System.Xml.Serialization.XmlElement("CorpId", IsNullable = true)]
        public string? ParentCorpId { get; set; }

        /// <summary>
        /// 获取或设置上级企业应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentId")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentId")]
        [System.Xml.Serialization.XmlElement("AgentId")]
        public int ParentAgentId { get; set; }

        /// <summary>
        /// 获取或设置下级企业应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppId")]
        [System.Text.Json.Serialization.JsonPropertyName("AppId")]
        [System.Xml.Serialization.XmlElement("AppId", IsNullable = true)]
        public int? AgentId { get; set; }
    }
}
