namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [GET] /ecommerce/applyments/{applyment_id} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetEcommerceApplymentByOutRequestNumberResponse))]
    public class GetEcommerceApplymentByApplymentIdResponse : GetEcommerceApplymentByOutRequestNumberResponse
    {
    }
}
