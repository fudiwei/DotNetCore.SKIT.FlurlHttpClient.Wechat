namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_register_code 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetRegisterCodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推广包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_name")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
        public string? CorpName { get; set; }

        /// <summary>
        /// 获取或设置管理员姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_name")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_name")]
        public string? AdminName { get; set; }

        /// <summary>
        /// 获取或设置管理员手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_mobile")]
        public string? AdminMobileNumber { get; set; }

        /// <summary>
        /// 获取或设置自定义渠道参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置跟进人的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("follow_user")]
        [System.Text.Json.Serialization.JsonPropertyName("follow_user")]
        public string? FollowUserId { get; set; }
    }
}
