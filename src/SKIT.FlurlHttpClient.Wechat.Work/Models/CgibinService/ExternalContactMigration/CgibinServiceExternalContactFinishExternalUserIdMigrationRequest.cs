namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/externalcontact/finish_external_userid_migration 接口的请求。</para>
    /// </summary>
    public class CgibinServiceExternalContactFinishExternalUserIdMigrationRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置迁移完成的企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;
    }
}
