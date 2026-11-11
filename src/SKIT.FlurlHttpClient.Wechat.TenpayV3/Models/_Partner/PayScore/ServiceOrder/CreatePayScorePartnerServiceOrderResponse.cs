namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [POST] /payscore/partner/serviceorder 接口的响应。</para>
    /// </summary>
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetPayScorePartnerServiceOrderByOutOrderNumberResponse))]
    public class CreatePayScorePartnerServiceOrderResponse : GetPayScorePartnerServiceOrderByOutOrderNumberResponse
    {
        /// <summary>
        /// 获取或设置跳转微信侧小程序订单数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package")]
        [System.Text.Json.Serialization.JsonPropertyName("package")]
        public string? Package { get; set; }
    }
}
