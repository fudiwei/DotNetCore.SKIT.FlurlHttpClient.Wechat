namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyerdisplaytag 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerDisplayTagResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置自定义客户标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("display_tag_list")]
        public string[] DisplayTagList { get; set; } = default!;
    }
}
