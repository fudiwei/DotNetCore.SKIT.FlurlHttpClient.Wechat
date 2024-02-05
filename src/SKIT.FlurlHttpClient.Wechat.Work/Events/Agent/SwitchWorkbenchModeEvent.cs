namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.switch_workbench_mode 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92535 ]]>
    /// </para>
    /// </summary>
    public class SwitchWorkbenchModeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置自定义模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Mode")]
        [System.Text.Json.Serialization.JsonPropertyName("Mode")]
        [System.Xml.Serialization.XmlElement("Mode")]
        public int Mode { get; set; }
    }
}
