using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer-detail/electronic-receipts 接口的响应。</para>
    /// </summary>
    public class GetTransferDetailElectronicReceiptByOutDetailNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置受理类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_type")]
        [System.Text.Json.Serialization.JsonPropertyName("accept_type")]
        public string AcceptType { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
        public string OutDetailNumber { get; set; } = default!;

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
    }
}
