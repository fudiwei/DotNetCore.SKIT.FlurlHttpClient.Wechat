namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/getidlist 接口的响应。</para>
    /// </summary>
    public class CgibinTagsGetIdListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户身上的标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid_list")]
        public int[] TagIdList { get; set; } = default!;
    }
}
