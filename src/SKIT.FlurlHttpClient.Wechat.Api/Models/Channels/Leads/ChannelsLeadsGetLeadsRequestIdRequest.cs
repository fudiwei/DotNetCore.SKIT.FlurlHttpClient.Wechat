namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_request_id 接口的请求。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsRequestIdRequest : WechatApiRequest, IInferable<ChannelsLeadsGetLeadsRequestIdRequest, ChannelsLeadsGetLeadsRequestIdResponse>
    {
        /// <summary>
        /// 获取或设置留资组件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leads_component_id")]
        [System.Text.Json.Serialization.JsonPropertyName("leads_component_id")]
        public string LeadsComponentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }
    }
}
