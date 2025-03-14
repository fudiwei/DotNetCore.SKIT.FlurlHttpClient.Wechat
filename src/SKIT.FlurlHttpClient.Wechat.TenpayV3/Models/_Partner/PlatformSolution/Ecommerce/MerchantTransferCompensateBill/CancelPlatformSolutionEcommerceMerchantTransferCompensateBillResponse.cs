using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/mch-transfer/compensate-bills/out-bill-no/{out_bill_no}/cancel 接口的响应。</para>
    /// </summary>
    public class CancelPlatformSolutionEcommerceMerchantTransferCompensateBillResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
        public string BillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置撤销受理时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_accept_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_accept_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CancelAcceptTime { get; set; }
    }
}
