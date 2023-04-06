using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /partner-transfer/batches/batch-id/{batch_id} 接口的响应。</para>
    /// </summary>
    public class GetPartnerTransferBatchByBatchIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferDetail : GetPartnerTransferBatchByOutBatchNumberResponse.Types.TransferDetail
            {
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置特约商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

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
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_status")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_status")]
        public string BatchStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_type")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_type")]
        public string BatchType { get; set; } = default!;

        /// <summary>
        /// 获取或设置特约商户授权类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_type")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_type")]
        public string AuthorizationType { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_name")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_name")]
        public string BatchName { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_remark")]
        public string BatchRemark { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次关闭原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("close_reason")]
        public string? CloseReason { get; set; }

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
        /// 获取或设置批次创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置批次更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? UpdateTime { get; set; }

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
        /// 获取或设置转账用途。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_purpose")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_purpose")]
        public string? TransferPurpose { get; set; }

        /// <summary>
        /// 获取或设置转账明细单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_detail_list")]
        public Types.TransferDetail[]? TransferDetailList { get; set; }
    }
}
