using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/serviceorder/{out_order_no}/send-pendingmessage 接口的请求。</para>
    /// </summary>
    public class SendPayScoreServiceOrderPendingMessageRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payment : CreatePayScoreServiceOrderRequest.Types.Payment
            {
            }

            public class Discount : CreatePayScoreServiceOrderRequest.Types.Discount
            {
            }
        }

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public IList<Types.Payment> PostPaymentList { get; set; } = new List<Types.Payment>();

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public IList<Types.Discount>? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置总金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置预计扣费时间字符串（格式：yyyyMMddHH）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepaid_time")]
        [System.Text.Json.Serialization.JsonPropertyName("prepaid_time")]
        public string? PrepaidTimeString { get; set; }
    }
}
