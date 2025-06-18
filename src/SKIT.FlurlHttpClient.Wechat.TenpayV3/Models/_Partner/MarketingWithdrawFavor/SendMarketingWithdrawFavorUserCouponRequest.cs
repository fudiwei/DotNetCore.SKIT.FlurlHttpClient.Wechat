namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/withdraw-favor/users/{openid}/coupons 接口的请求。</para>
    /// </summary>
    public class SendMarketingWithdrawFavorUserCouponRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行提现免费券批次创建方商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string CreatorMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行提现免费券批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发券时商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
        public string SendOutRequestNumber { get; set; } = string.Empty;
    }
}
