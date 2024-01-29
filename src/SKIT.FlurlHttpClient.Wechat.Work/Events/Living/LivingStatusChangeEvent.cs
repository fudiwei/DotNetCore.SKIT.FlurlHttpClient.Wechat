namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.living_status_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94145 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94308 </para>
    /// </summary>
    public class LivingStatusChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LivingId")]
        [System.Text.Json.Serialization.JsonPropertyName("LivingId")]
        [System.Xml.Serialization.XmlElement("LivingId")]
        public string LivingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置直播状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status")]
        public int Status { get; set; }
    }
}
