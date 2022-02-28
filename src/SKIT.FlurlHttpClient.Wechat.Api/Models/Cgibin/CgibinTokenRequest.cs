namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/token 接口的请求。</para>
    /// </summary>
    public class CgibinTokenRequest : WechatApiRequest, IMapResponse<CgibinTokenRequest, CgibinTokenResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "client_credential";
    }
}
