namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/tag/get 接口的请求。</para>
    /// </summary>
    public class CgibinUserTagGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int TagId { get; set; }

        /// <summary>
        /// 获取或设置第一个拉取的 OpenId。不填默认从头开始拉取。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("next_openid")]
        public string? NextOpenId { get; set; }
    }
}
