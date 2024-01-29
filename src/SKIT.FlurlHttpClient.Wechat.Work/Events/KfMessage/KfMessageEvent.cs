namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.kf_msg_or_event 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94670 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94699 </para>
    /// </summary>
    public class KfMessageEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置调用拉取消息的 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Token")]
        [System.Text.Json.Serialization.JsonPropertyName("Token")]
        [System.Xml.Serialization.XmlElement("Token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenKfId")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenKfId")]
        [System.Xml.Serialization.XmlElement("OpenKfId")]
        public string OpenKfId { get; set; } = default!;
    }
}
