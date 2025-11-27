namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_short_link 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponShortLinkRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetCouponShortLinkRequest, ChannelsECPromoterGetCouponShortLinkResponse>
    {
        /// <summary>
        /// 获取或设置推客的微信电商平台注册的身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置来源的机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("from_head_supplier_appid")]
        public string? FromHeadSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long CouponId { get; set; }
    }
}
