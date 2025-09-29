namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.dropship_order_update 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/supplier/notify/ds_order_notify/ds_order_update_notice.html ]]>
    /// </para>
    /// </summary>
    public class DropshipOrderUpdateEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置代发单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ds_order_id")]
        [System.Xml.Serialization.XmlElement("ds_order_id")]
        public string DropshipOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置更新时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Xml.Serialization.XmlElement("update_time")]
        public long UpdateTimestamp { get; set; }
    }
}
