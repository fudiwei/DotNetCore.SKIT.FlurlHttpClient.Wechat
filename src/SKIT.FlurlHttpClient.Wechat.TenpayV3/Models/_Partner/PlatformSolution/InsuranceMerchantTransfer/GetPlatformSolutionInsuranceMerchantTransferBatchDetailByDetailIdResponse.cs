namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [GET] /platsolution/insurance/mch-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumberResponse))]
    public class GetPlatformSolutionInsuranceMerchantTransferBatchDetailByDetailIdResponse : GetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumberResponse
    {
    }
}
