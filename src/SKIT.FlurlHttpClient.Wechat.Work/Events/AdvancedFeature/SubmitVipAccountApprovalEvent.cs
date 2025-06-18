namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.submit_vip_account_approval 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99876 ]]>
    /// </para>
    /// </summary>
    public class SubmitVipAccountApprovalEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置申请的高级账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BusinessType")]
        [System.Text.Json.Serialization.JsonPropertyName("BusinessType")]
        [System.Xml.Serialization.XmlElement("BusinessType")]
        public int BusinessType { get; set; }

        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyId")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyId")]
        [System.Xml.Serialization.XmlElement("ApplyId")]
        public string ApplyId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyReason")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyReason")]
        [System.Xml.Serialization.XmlElement("ApplyReason")]
        public string ApplyReason { get; set; } = default!;
    }
}
