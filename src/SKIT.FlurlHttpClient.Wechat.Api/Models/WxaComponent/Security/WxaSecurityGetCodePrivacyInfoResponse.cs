namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/security/get_code_privacy_info 接口的响应。</para>
    /// </summary>
    public class WxaSecurityGetCodePrivacyInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置没权限的隐私接口的 API 英文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("without_auth_list")]
        [System.Text.Json.Serialization.JsonPropertyName("without_auth_list")]
        public string[] WithoutAuthApiNameList { get; set; } = default!;

        /// <summary>
        /// 获取或设置没配置的隐私接口的 API 英文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("without_conf_list")]
        [System.Text.Json.Serialization.JsonPropertyName("without_conf_list")]
        public string[] WithoutConfigApiNameList { get; set; } = default!;
    }
}
