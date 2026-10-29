namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.TEMPLATESENDJOBFINISH" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/public/api_freepublish_submit.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/public/api_freepublish_submit.html ]]>
    /// </para>
    /// </summary>
    public class TemplateSendJobFinishEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgID")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置发送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status")]
        public string? Status { get; set; }
    }
}
