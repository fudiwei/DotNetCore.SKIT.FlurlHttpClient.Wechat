namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/userinfo 接口的请求。</para>
    /// </summary>
    public class SnsUserInfoRequest : WechatApiRequest, IInferable<SnsUserInfoRequest, SnsUserInfoResponse>
    {
        /// <summary>
        /// 获取或设置网页授权接口调用凭证（注意与全局 AccessToken 相区分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置返回国家地区语言版本。
        /// <para>默认值："zh_CN"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Language { get; set; } = "zh_CN";
    }
}
