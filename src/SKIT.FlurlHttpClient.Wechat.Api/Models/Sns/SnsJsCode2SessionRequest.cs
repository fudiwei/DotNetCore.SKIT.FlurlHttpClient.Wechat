namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/jscode2session 接口的请求。</para>
    /// </summary>
    public class SnsJsCode2SessionRequest : WechatApiRequest, IInferable<SnsJsCode2SessionRequest, SnsJsCode2SessionResponse>
    {
        /// <summary>
        /// 获取或设置授权类型。
        /// <para>默认值："authorization_code"</para>
        /// <remarks><i>（使用默认值即可，无需修改）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? GrantType { get; set; } = "authorization_code";

        /// <summary>
        /// 获取或设置登录时获取的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? JsCode { get; set; }
    }
}
