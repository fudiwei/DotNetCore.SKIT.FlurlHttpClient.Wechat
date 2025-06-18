namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/mch-transfer/elecsign/transfer-bill-no/{transfer_bill_no} 接口的请求。</para>
    /// </summary>
    public class GetFundAppMerchantTransferElecsignByTransferBillNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信转账单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TransferBillNumber { get; set; } = string.Empty;
    }
}
