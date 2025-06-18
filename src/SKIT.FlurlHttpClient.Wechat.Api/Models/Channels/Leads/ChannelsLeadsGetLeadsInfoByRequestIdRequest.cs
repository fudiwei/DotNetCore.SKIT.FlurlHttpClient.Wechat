namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_info_by_request_id 接口的请求。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsInfoByRequestIdRequest : WechatApiRequest, IInferable<ChannelsLeadsGetLeadsInfoByRequestIdRequest, ChannelsLeadsGetLeadsInfoByRequestIdResponse>
    {
        /// <summary>
        /// 获取或设置留资请求 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string RequestId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }
    }
}
