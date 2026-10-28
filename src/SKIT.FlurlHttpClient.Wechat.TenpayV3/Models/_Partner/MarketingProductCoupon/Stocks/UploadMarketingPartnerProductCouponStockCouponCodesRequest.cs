namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/upload-coupon-codes 接口的请求。</para>
    /// </summary>
    public class UploadMarketingPartnerProductCouponStockCouponCodesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ProductCouponId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? StockId { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumebr { get; set; }

        /// <summary>
        /// 获取或设置券 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("code_list")]
        public List<string>? CodeList { get; set; }
    }
}
