namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycodequery 接口的请求。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeQueryRequest : WechatApiRequest, IMapResponse<IntpMarketCodeApplyCodeQueryRequest, IntpMarketCodeApplyCodeQueryResponse>
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// 获取或设置外部单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isv_application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("isv_application_id")]
        public string? ISVApplicationId { get; set; }
    }
}
