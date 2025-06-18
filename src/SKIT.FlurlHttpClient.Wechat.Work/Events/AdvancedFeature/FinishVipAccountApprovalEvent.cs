namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.finish_vip_account_approval 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99877 ]]>
    /// </para>
    /// </summary>
    public class FinishVipAccountApprovalEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置状态改变类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FinishType")]
        [System.Text.Json.Serialization.JsonPropertyName("FinishType")]
        [System.Xml.Serialization.XmlElement("FinishType")]
        public int FinishType { get; set; }

        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyId")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyId")]
        [System.Xml.Serialization.XmlElement("ApplyId")]
        public string ApplyId { get; set; } = default!;
    }
}
