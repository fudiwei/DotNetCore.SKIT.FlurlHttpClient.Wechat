namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/set_authorizer_option 接口的请求。</para>
    /// </summary>
    public class CgibinComponentSetAuthorizerOptionRequest : WechatApiRequest, IInferable<CgibinComponentSetAuthorizerOptionRequest, CgibinComponentSetAuthorizerOptionResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置选项名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_name")]
        [System.Text.Json.Serialization.JsonPropertyName("option_name")]
        public string? OptionName { get; set; }

        /// <summary>
        /// 获取或设置选项值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_value")]
        [System.Text.Json.Serialization.JsonPropertyName("option_value")]
        public string? OptionValue { get; set; }
    }
}
