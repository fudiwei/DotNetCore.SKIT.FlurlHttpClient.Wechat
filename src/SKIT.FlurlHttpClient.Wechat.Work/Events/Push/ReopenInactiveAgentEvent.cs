namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.reopen_inactive_agent 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90240 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90376 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90858 ]]>
    /// </para>
    /// </summary>
    public class ReopenInactiveAgentEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }
    }
}
