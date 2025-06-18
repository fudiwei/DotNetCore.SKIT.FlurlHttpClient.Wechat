namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/homepage/background/apply/cancel 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsHomepageBackgroundApplyCancelRequest : WechatApiRequest, IInferable<ChannelsECBasicsHomepageBackgroundApplyCancelRequest, ChannelsECBasicsHomepageBackgroundApplyCancelResponse>
    {
        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public long ApplyId { get; set; }
    }
}
