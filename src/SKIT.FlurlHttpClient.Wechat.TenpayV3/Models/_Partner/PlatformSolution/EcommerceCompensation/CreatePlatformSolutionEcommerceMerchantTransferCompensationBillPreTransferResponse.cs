using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/mch-transfer/compensate-bills/pre-transfer 接口的响应。</para>
    /// </summary>
    public class CreatePlatformSolutionEcommerceMerchantTransferCompensationBillPreTransferResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

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
        /// 获取或设置受理时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AcceptTime { get; set; }

        /// <summary>
        /// 获取或设置跳转领取页面的携带信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_info")]
        [System.Text.Json.Serialization.JsonPropertyName("package_info")]
        public string PackageInfo { get; set; } = default!;
    }
}
