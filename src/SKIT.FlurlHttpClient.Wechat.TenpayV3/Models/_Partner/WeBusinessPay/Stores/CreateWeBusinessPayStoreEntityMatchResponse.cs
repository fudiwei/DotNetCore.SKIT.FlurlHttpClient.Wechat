using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/stores/entity-matches 接口的响应。</para>
    /// </summary>
    public class CreateWeBusinessPayStoreEntityMatchResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户主体匹配批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_id")]
        public string OutBatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付主体匹配批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
