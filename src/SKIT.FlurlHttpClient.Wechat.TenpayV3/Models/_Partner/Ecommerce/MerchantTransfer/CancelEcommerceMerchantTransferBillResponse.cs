using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/mch-transfer/transfer-bills/out-bill-no/{out_bill_no}/cancel 接口的响应。</para>
    /// </summary>
    public class CancelEcommerceMerchantTransferBillResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户转账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_bill_no")]
        public string OutBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信转账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_bill_no")]
        public string TransferBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置单据状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
