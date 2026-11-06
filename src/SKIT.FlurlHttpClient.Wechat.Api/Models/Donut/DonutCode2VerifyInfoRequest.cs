namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /donut/code2verifyinfo 接口的请求。</para>
    /// </summary>
    public class DonutCode2VerifyInfoRequest : WechatApiRequest, IInferable<DonutCode2VerifyInfoRequest, DonutCode2VerifyInfoResponse>
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
        /// 获取或设置临时登录凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }
    }
}
