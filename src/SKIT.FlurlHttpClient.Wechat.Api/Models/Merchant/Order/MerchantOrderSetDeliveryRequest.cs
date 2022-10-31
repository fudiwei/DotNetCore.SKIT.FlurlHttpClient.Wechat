using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/order/setdelivery 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantOrderSetDeliveryRequest : WechatApiRequest, IInferable<MerchantOrderSetDeliveryRequest, MerchantOrderSetDeliveryResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_company")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_company")]
        public string? DeliveryCompany { get; set; }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_track_no")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_track_no")]
        public string? DeliveryId { get; set; }

        /// <summary>
        /// 获取或设置是否需要物流。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_delivery")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_delivery")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? RequireDelivery { get; set; }

        /// <summary>
        /// 获取或设置是否其他物流公司。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_others")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_others")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsOtherCompany { get; set; }
    }
}
