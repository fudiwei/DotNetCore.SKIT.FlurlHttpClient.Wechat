namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/getmsgrelation 接口的请求。</para>
    /// </summary>
    public class CityServiceGetMessageRelationRequest : WechatApiRequest, IInferable<CityServiceGetMessageRelationRequest, CityServiceGetMessageRelationResponse>
    {
        /// <summary>
        /// 获取或设置业务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
        public int BusinessId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;
    }
}
