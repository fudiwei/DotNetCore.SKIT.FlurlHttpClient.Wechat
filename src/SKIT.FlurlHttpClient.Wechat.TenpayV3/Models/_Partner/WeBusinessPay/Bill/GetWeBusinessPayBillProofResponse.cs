using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/bill/proof 接口的响应。</para>
    /// </summary>
    public class GetWeBusinessPayBillProofResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string StartDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_name")]
        public string? EntityName { get; set; }

        /// <summary>
        /// 获取或设置商户操作流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_operation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_operation_id")]
        public string OutOperationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付操作流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string OperationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置出资凭证申请单单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("proof_id")]
        [System.Text.Json.Serialization.JsonPropertyName("proof_id")]
        public string ProofId { get; set; } = default!;

        /// <summary>
        /// 获取或设置账单下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updated_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
