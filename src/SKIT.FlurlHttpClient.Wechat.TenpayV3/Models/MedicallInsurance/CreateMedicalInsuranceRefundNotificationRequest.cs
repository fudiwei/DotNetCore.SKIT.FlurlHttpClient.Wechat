using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /med-ins/refunds/notify 接口的请求。</para>
    /// </summary>
    public class CreateMedicalInsuranceRefundNotificationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置医保自费混合订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MixTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置医保退款的总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_refund_total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_refund_total_fee")]
        public int MedicalRefundTotalFee { get; set; }

        /// <summary>
        /// 获取或设置医保统筹退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_refund_gov_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_refund_gov_fee")]
        public int MedicalRefundGovernerFee { get; set; }

        /// <summary>
        /// 获取或设置医保个账退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_refund_self_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_refund_self_fee")]
        public int MedicalRefundSelfFee { get; set; }

        /// <summary>
        /// 获取或设置医保其他退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_refund_other_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_refund_other_fee")]
        public int? MedicalRefundOtherFee { get; set; }

        /// <summary>
        /// 获取或设置医保退款成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset RefundTime { get; set; }
    }
}
