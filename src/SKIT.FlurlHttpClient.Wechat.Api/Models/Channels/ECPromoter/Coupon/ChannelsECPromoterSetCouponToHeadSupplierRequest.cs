namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/set_coupon_to_headsupplier 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterSetCouponToHeadSupplierRequest : WechatApiRequest, IInferable<ChannelsECPromoterSetCouponToHeadSupplierRequest, ChannelsECPromoterSetCouponToHeadSupplierResponse>
    {
        /// <summary>
        /// 获取或设置接收的机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_head_supplier_appid")]
        public string ToHeadSupplierAppId { get; set; } = string.Empty;

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
