namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_active_info_by_code 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseGetActiveInfoByCodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账号激活码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_code")]
        [System.Text.Json.Serialization.JsonPropertyName("active_code")]
        public string ActiveCode { get; set; } = string.Empty;
    }
}
