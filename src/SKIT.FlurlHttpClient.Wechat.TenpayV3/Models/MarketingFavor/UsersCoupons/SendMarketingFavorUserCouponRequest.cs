namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/favor/users/{openid}/coupons 接口的请求。</para>
    /// </summary>
    public class SendMarketingFavorUserCouponRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置创建批次的商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_creator_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_creator_mchid")]
        public string? StockCreatorMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户单据号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置指定发券面额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_value")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_value")]
        public int? CouponAmount { get; set; }

        /// <summary>
        /// 获取或设置指定发券使用门槛（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_minimum")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_minimum")]
        public int? TransactionMinimum { get; set; }
    }
}
