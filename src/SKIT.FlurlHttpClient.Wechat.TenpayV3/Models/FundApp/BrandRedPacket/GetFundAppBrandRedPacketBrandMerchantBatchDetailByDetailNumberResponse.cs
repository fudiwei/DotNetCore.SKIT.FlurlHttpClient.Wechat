namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [GET] /fund-app/brand-redpacket/brand-merchant-batches/{batch_no}/details/{detail_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberResponse))]
    public class GetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumberResponse : GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberResponse
    {
    }
}
