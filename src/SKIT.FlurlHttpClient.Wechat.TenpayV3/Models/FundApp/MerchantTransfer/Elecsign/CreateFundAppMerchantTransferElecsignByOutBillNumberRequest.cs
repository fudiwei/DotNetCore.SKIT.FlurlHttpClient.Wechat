namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/mch-transfer/elecsign/out-bill-no 接口的请求。</para>
    /// </summary>
    public class CreateFundAppMerchantTransferElecsignByOutBillNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = string.Empty;
    }
}
