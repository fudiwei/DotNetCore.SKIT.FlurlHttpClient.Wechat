namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getmsgclickdata 接口的请求。</para>
    /// </summary>
    public class PromoterGetMessageClickDataRequest : PublisherStatSettlementRequest, IInferable<PromoterGetMessageClickDataRequest, PromoterGetMessageClickDataResponse>
    {
        /// <summary>
        /// 获取或设置数据统计维度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dimonsion")]
        [System.Text.Json.Serialization.JsonPropertyName("dimonsion")]
        public int Dimension { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public int? MessageType { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// 获取或设置消息发送日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_date")]
        [System.Text.Json.Serialization.JsonPropertyName("send_date")]
        public string? SendDateString { get; set; }

        /// <summary>
        /// 获取或设置消息发送开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_send_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_send_time")]
        public long? BeginSendTimestamp { get; set; }

        /// <summary>
        /// 获取或设置消息发送结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_send_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_send_time")]
        public long? EndSendTimestamp { get; set; }

    }
}
