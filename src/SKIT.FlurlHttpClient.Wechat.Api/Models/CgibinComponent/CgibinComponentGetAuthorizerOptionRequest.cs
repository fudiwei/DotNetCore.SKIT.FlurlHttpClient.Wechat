namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/get_authorizer_option 接口的请求。</para>
    /// </summary>
    public class CgibinComponentGetAuthorizerOptionRequest : WechatApiRequest, IInferable<CgibinComponentGetAuthorizerOptionRequest, CgibinComponentGetAuthorizerOptionResponse>
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
    }
}
