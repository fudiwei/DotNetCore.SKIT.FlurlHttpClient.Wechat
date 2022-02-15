namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyerrelationbybuyer 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerRelationByBuyerRequest : WechatApiRequest, IMapResponse<CgibinGuideGetGuideBuyerRelationByBuyerRequest, CgibinGuideGetGuideBuyerRelationByBuyerResponse>
    {
        /// <summary>
        /// 获取或设置客户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string BuyerOpenId { get; set; } = string.Empty;
    }
}
