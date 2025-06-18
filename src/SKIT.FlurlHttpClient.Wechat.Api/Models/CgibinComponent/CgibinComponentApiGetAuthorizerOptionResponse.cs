namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_get_authorizer_option 接口的响应。</para>
    /// </summary>
    public class CgibinComponentApiGetAuthorizerOptionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
        public string AuthorizerAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置选项名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_name")]
        [System.Text.Json.Serialization.JsonPropertyName("option_name")]
        public string OptionName { get; set; } = default!;

        /// <summary>
        /// 获取或设置选项值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_value")]
        [System.Text.Json.Serialization.JsonPropertyName("option_value")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string OptionValue { get; set; } = default!;
    }
}
