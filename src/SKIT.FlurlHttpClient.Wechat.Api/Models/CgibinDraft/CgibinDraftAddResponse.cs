namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/draft/add 接口的响应。</para>
    /// </summary>
    public class CgibinDraftAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置草稿的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;
    }
}
