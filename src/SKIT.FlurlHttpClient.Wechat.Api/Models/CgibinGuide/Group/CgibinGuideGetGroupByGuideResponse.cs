namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getgroupbyguide 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGroupByGuideResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置顾问分组 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id_list")]
        public long[] GroupIdList { get; set; } = default!;
    }
}
