namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/quickcheckstudentidentity 接口的请求。</para>
    /// </summary>
    public class IntpQuickCheckStudentIdentityRequest : WechatApiRequest, IInferable<IntpQuickCheckStudentIdentityRequest, IntpQuickCheckStudentIdentityResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户授权查询 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_studentcheck_code")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_studentcheck_code")]
        public string CheckCode { get; set; } = string.Empty;
    }
}
