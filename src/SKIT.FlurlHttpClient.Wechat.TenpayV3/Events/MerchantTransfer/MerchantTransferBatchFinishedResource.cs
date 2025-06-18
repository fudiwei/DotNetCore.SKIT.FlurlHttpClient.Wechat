using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 MCHTRANSFER.BATCH.FINISHED 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012269028 ]]> <br/>
    /// </para>
    /// </summary>
    public class MerchantTransferBatchFinishedResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_status")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_status")]
        public string BatchStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置转账总笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalNumber { get; set; }

        /// <summary>
        /// 获取或设置转账成功金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("success_amount")]
        public int SuccessAmount { get; set; }

        /// <summary>
        /// 获取或设置转账成功笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_num")]
        [System.Text.Json.Serialization.JsonPropertyName("success_num")]
        public int SuccessNumber { get; set; }

        /// <summary>
        /// 获取或设置转账失败金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_amount")]
        public int FailAmount { get; set; }

        /// <summary>
        /// 获取或设置转账失败笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_num")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_num")]
        public int FailNumber { get; set; }

        /// <summary>
        /// 获取或设置批次更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
