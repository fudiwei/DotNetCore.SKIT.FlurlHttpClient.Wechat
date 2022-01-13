namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_suite_token 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetSuiteTokenResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置第三方应用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suite_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("suite_access_token")]
        public string SuiteAccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置第三方应用凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
