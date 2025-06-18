namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/set_auto_active_status 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseSetAutoActiveStatusRequest : WechatWorkRequest
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
        /// 获取或设置许可自动激活状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_active_status")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_active_status")]
        public int AutoActiveStatus { get; set; }
    }
}
