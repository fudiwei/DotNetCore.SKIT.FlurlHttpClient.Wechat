namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/open/sameentity 接口的响应。</para>
    /// </summary>
    public class CgibinOpenSameEntityResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否相同主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("same_entity")]
        [System.Text.Json.Serialization.JsonPropertyName("same_entity")]
        public bool IsSameEntity { get; set; }
    }
}
