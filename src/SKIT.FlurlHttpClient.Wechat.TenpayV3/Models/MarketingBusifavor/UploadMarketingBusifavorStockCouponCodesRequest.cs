using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/stocks/{stock_id}/couponcodes 接口的请求。</para>
    /// </summary>
    public class UploadMarketingBusifavorStockCouponCodesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家券 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code_list")]
        public IList<string> CouponCodeList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
