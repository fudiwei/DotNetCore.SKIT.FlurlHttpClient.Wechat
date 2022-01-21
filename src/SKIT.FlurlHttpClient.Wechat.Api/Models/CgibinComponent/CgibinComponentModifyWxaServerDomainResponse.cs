namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/modify_wxa_server_domain 接口的响应。</para>
    /// </summary>
    public class CgibinComponentModifyWxaServerDomainResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置目前生效的全网发布版第三方平台小程序服务器域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("published_wxa_server_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithSemicolonSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("published_wxa_server_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithSemicolonSplitConverter))]
        public string[]? PublishedWxaServerDomainList { get; set; }

        /// <summary>
        /// 获取或设置目前生效的测试版第三方平台小程序服务器域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testing_wxa_server_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithSemicolonSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("testing_wxa_server_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithSemicolonSplitConverter))]
        public string[]? TestingWxaServerDomainList { get; set; }

        /// <summary>
        /// 获取或设置未通过验证的第三方平台小程序服务器域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_wxa_server_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithSemicolonSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_wxa_server_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithSemicolonSplitConverter))]
        public string[]? InvalidWxaServerDomainList { get; set; }
    }
}
