namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/brand-redpacket/brand-merchant-out-batches/{out_batch_no}/out-details/{out_detail_no} 接口的请求。</para>
    /// </summary>
    public class GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商家批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutDetailNumber { get; set; } = string.Empty;
    }
}
