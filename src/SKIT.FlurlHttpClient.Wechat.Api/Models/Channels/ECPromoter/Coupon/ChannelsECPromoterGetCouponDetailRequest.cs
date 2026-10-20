namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_detail 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponDetailRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetCouponDetailRequest, ChannelsECPromoterGetCouponDetailResponse>
    {
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
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long CouponId { get; set; }
    }
}
