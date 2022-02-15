using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /transfer/batches 接口的响应。</para>
    /// </summary>
    public class CreateTransferBatchResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
