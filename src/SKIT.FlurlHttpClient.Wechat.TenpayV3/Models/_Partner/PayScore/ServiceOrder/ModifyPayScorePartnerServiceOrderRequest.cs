namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/partner/serviceorder/{out_order_no}/modify 接口的请求。</para>
    /// </summary>
    public class ModifyPayScorePartnerServiceOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class PostPayment : CreatePayScorePartnerServiceOrderRequest.Types.PostPayment
            {
            }

            public class PostDiscount : CreatePayScorePartnerServiceOrderRequest.Types.PostDiscount
            {
            }

            public class Device : CreatePayScorePartnerServiceOrderRequest.Types.Device
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户服务单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public List<Types.PostPayment>? PostPaymentList { get; set; }

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public List<Types.PostDiscount>? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置设备信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device")]
        [System.Text.Json.Serialization.JsonPropertyName("device")]
        public Types.Device? Device { get; set; }

        /// <summary>
        /// 获取或设置总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置修改原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
