namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/activity/stop 接口的请求。</para>
    /// </summary>
    public class ChannelsECActivityStopRequest : WechatApiRequest, IInferable<ChannelsECActivityStopRequest, ChannelsECActivityStopResponse>
    {
        /// <summary>
        /// 获取或设置买赠活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }
    }
}
