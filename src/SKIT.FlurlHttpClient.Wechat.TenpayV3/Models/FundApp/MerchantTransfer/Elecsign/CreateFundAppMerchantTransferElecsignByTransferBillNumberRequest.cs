namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/elecsign/transfer-bill-no 接口的请求。</para>
    /// </summary>
    public class CreateFundAppMerchantTransferElecsignByTransferBillNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信转账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_bill_no")]
        public string TransferBillNumber { get; set; } = string.Empty;
    }
}
