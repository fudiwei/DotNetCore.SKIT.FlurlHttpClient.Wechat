namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/permissions/authorization-code/{authorization_code} 接口的请求。</para>
    /// </summary>
    public class GetPayScorePermissionsByAuthorizationCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置授权协议号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AuthorizationCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ServiceId { get; set; } = string.Empty;
    }
}
