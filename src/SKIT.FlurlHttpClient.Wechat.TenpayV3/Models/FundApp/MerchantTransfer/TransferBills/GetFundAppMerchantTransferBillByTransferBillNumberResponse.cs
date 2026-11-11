namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [GET] /fund-app/mch-transfer/transfer-bills/transfer-bill-no/{transfer_bill_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetFundAppMerchantTransferBillByOutBillNumberResponse))]
    public class GetFundAppMerchantTransferBillByTransferBillNumberResponse : GetFundAppMerchantTransferBillByOutBillNumberResponse
    {
    }
}
