namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/realnumberviewaudit/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderRealNumberViewAuditGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
        public string? TaskId { get; set; }

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_state")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_state")]
        public int AuditState { get; set; }

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_reason")]
        public string? ApplyReason { get; set; }

        /// <summary>
        /// 获取或设置申请时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_time")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
        public long ApplyTimestampMilli { get; set; }
    }
}
