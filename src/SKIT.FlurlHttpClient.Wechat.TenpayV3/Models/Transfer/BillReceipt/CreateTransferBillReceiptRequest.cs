using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /transfer/bill-receipt 接口的请求。</para>
    /// </summary>
    public class CreateTransferBillReceiptRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = string.Empty;
    }
}
