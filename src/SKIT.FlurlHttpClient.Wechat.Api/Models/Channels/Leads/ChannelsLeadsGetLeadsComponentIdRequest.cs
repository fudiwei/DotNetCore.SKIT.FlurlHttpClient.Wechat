namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_component_id 接口的请求。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsComponentIdRequest : WechatApiRequest, IInferable<ChannelsLeadsGetLeadsComponentIdRequest, ChannelsLeadsGetLeadsComponentIdResponse>
    {
        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }
    }
}
