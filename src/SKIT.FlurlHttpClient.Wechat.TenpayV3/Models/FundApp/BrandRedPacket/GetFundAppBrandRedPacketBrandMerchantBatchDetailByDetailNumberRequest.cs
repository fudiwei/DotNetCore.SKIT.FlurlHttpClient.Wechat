namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/brand-redpacket/brand-merchant-batches/{batch_no}/details/{detail_no} 接口的请求。</para>
    /// </summary>
    public class GetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DetailNumber { get; set; } = string.Empty;
    }
}
