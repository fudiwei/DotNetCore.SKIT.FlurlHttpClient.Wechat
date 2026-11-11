namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/transfer-to-qq-wallet-bills/{out_bill_no}/cancel 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetFundAppMerchantTransferToQQWalletBillByOutBillNumberResponse))]
    public class CancelFundAppMerchantTransferToQQWalletBillResponse : GetFundAppMerchantTransferToQQWalletBillByOutBillNumberResponse
    {
    }
}
