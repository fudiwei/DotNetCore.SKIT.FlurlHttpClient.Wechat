namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openapi/quota/get 接口的请求。</para>
    /// </summary>
    public class CgibinOpenApiQuotaGetRequest : WechatApiRequest, IMapResponse<CgibinOpenApiQuotaGetRequest, CgibinOpenApiQuotaGetResponse>
    {
        /// <summary>
        /// 获取或设置 API 请求地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cgi_path")]
        [System.Text.Json.Serialization.JsonPropertyName("cgi_path")]
        public string CgiPath { get; set; } = string.Empty;
    }
}
