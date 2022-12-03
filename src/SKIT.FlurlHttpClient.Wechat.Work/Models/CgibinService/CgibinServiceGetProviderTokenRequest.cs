namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_provider_token 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetProviderTokenRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置企业微信 CorpId。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.CorpId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string? CorpId { get; set; }

        /// <summary>
        /// 获取或设置企业微信服务商 Secret。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.ProviderSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provider_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("provider_secret")]
        public string? ProviderSecret { get; set; }
    }
}
