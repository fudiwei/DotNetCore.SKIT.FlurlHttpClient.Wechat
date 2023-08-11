namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/busifavor/subsidy/pay-receipts 接口的请求。</para>
    /// </summary>
    public class QueryMarketingBusifavorSubsidyPayReceiptsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商家券批次号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CouponCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置补差请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutSubsidyNumber { get; set; }
    }
}
