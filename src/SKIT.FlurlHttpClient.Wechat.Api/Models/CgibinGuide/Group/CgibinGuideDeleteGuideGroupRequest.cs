namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/delguidegroup 接口的请求。</para>
    /// </summary>
    public class CgibinGuideDeleteGuideGroupRequest : WechatApiRequest, IMapResponse<CgibinGuideDeleteGuideGroupRequest, CgibinGuideDeleteGuideGroupResponse>
    {
        /// <summary>
        /// 获取或设置顾问分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public long GroupId { get; set; }
    }
}
