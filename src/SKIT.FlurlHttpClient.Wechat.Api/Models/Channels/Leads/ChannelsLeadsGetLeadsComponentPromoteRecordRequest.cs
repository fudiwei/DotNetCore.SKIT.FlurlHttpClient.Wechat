namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_component_promote_record 接口的请求。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsComponentPromoteRecordRequest : WechatApiRequest, IInferable<ChannelsLeadsGetLeadsComponentPromoteRecordRequest, ChannelsLeadsGetLeadsComponentPromoteRecordResponse>
    {
        /// <summary>
        /// 获取或设置留资组件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leads_component_id")]
        [System.Text.Json.Serialization.JsonPropertyName("leads_component_id")]
        public string LeadsComponentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }
    }
}
