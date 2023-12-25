namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_get_authorizer_option 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiGetAuthorizerOptionRequest : WechatApiRequest, IInferable<CgibinComponentApiGetAuthorizerOptionRequest, CgibinComponentApiGetAuthorizerOptionResponse>
    {
        /// <summary>
        /// 获取或设置选项名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_name")]
        [System.Text.Json.Serialization.JsonPropertyName("option_name")]
        public string OptionName { get; set; } = string.Empty;
    }
}
