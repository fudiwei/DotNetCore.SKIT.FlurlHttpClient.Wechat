namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /transit/partnerpay/queryorder 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponseClassSystemTextJsonConverter))]
    public class GetTransitPartnerOrderResponse : GetTransitOrderResponse
    {
        public static new class Types
        {
            public class Coupon : GetTransitOrderResponse.Types.Coupon
            {
            }
        }

        internal static new class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase<GetTransitPartnerOrderResponse>
            {
            }

            internal class ResponseClassSystemTextJsonConverter : System.Text.Json.Converters.FlattenNArrayObjectConverterBase<GetTransitPartnerOrderResponse>
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置代金券使用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty(Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY)]
        [System.Text.Json.Serialization.JsonPropertyName(System.Text.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY)]
        public new Types.Coupon[]? CouponList { get; set; }
    }
}
