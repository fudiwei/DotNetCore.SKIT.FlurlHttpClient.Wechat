namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_set_authorizer_option 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiSetAuthorizerOptionRequest : WechatApiRequest, IInferable<CgibinComponentApiSetAuthorizerOptionRequest, CgibinComponentApiSetAuthorizerOptionResponse>
    {
        /// <summary>
        /// 获取或设置选项名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_name")]
        [System.Text.Json.Serialization.JsonPropertyName("option_name")]
        public string OptionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置选项值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_value")]
        [System.Text.Json.Serialization.JsonPropertyName("option_value")]
        public string OptionValue { get; set; } = string.Empty;
    }
}
