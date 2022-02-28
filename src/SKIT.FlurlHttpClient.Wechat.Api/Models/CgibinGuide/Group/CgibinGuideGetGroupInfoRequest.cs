namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getgroupinfo 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGroupInfoRequest : WechatApiRequest, IMapResponse<CgibinGuideGetGroupInfoRequest, CgibinGuideGetGroupInfoResponse>
    {
        /// <summary>
        /// 获取或设置顾问分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 0 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 0;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        [System.Text.Json.Serialization.JsonPropertyName("num")]
        public int Limit { get; set; } = 10;
    }
}
