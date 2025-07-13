namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/brand-redpacket/brand-merchant-batches/{batch_no} 接口的请求。</para>
    /// </summary>
    public class GetFundAppBrandRedPacketBrandMerchantBatchByBatchNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否查询红包明细单。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool RequireQueryDetail { get; set; }

        /// <summary>
        /// 获取或设置明细状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? DetailState { get; set; }
    }
}
