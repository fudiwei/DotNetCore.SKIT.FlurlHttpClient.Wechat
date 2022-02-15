﻿using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/bill-receipt/{out_batch_no} 接口的响应。</para>
    /// </summary>
    public class GetTransferBillReceiptByOutBatchNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置电子回单申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature_no")]
        [System.Text.Json.Serialization.JsonPropertyName("signature_no")]
        public string SignatureNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置电子回单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature_status")]
        [System.Text.Json.Serialization.JsonPropertyName("signature_status")]
        public string? SignatureStatus { get; set; }

        /// <summary>
        /// 获取或设置电子回单文件的哈希方法。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
        public string? HashType { get; set; }

        /// <summary>
        /// 获取或设置电子回单文件的哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_value")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
        public string? HashValue { get; set; }

        /// <summary>
        /// 获取或设置电子回单文件的下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? CreateTime { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? UpdateTime { get; set; }
    }
}
