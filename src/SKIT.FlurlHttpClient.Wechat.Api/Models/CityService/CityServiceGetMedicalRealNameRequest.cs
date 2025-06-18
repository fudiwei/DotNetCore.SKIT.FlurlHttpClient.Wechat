namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/getmedrealname 接口的请求。</para>
    /// </summary>
    public class CityServiceGetMedicalRealNameRequest : WechatApiRequest, IInferable<CityServiceGetMedicalRealNameRequest, CityServiceGetMedicalRealNameResponse>
    {
        /// <summary>
        /// 获取或设置业务方 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置实名信息 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxmed_authcode")]
        [System.Text.Json.Serialization.JsonPropertyName("wxmed_authcode")]
        public string AuthCode { get; set; } = string.Empty;
    }
}
