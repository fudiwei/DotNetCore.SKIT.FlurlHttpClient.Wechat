namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/open/have 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHaveResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否绑定开放平台帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("have_open")]
        [System.Text.Json.Serialization.JsonPropertyName("have_open")]
        public bool HasOpenAccount { get; set; }
    }
}
