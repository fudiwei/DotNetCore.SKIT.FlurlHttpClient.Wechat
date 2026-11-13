namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.check_biz" 回调通知应答的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/event_push/express/provider/Review_merchant_events.html ]]>
    /// </para>
    /// </summary>
    public class CheckBusinessReply : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizID")]
        [System.Text.Json.Serialization.JsonPropertyName("BizID")]
        [System.Xml.Serialization.XmlElement("BizID")]
        public string? BusinessId { get; set; }

        /// <summary>
        /// 获取或设置处理结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultCode")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultCode")]
        [System.Xml.Serialization.XmlElement("ResultCode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置处理结果错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultMsg")]
        [System.Xml.Serialization.XmlElement("ResultMsg", IsNullable = true)]
        public string? ResultMessage { get; set; }

        public CheckBusinessReply()
        {
            MessageType = "event";
            Event = "check_biz";
        }
    }
}
