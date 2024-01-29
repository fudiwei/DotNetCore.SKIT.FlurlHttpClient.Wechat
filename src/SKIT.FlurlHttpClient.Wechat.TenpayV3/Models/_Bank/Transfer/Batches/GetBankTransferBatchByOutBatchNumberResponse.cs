using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bank-transfer/batches/out-batch-no/{out_batch_no} 接口的响应。</para>
    /// </summary>
    public class GetBankTransferBatchByOutBatchNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferDetail
            {
                /// <summary>
                /// 获取或设置商户明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
                public string OutDetailNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_id")]
                public string DetailId { get; set; } = default!;

                /// <summary>
                /// 获取或设置明细状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_state")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_state")]
                public string DetailStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置银行服务商号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_sp_mchid")]
        public string BankMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务平台商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("platform_mchid")]
        public string PlatformMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款企业商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specialized_payment_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("specialized_payment_mchid")]
        public string SpecializedPaymentMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置实际出资商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsor_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sponsor_mchid")]
        public string SponsorMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户授权商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_authorized_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_authorized_mchid")]
        public string UserAuthorizedMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户授权 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_authorized_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_authorized_appid")]
        public string UserAuthorizedAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置银行批次单号。
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
        [Newtonsoft.Json.JsonProperty("batch_state")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_state")]
        public string BatchStatus { get; set; } = default!;

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
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("attach_remark")]
        public string? Attachment { get; set; }

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
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置批次创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置批次更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
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
        [Newtonsoft.Json.JsonProperty("success_count")]
        [System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int SuccessCount { get; set; }

        /// <summary>
        /// 获取或设置转账失败金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_amount")]
        public int FailAmount { get; set; }

        /// <summary>
        /// 获取或设置转账失败笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_count")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_count")]
        public int FailCount { get; set; }

        /// <summary>
        /// 获取或设置转账场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene")]
        public string? TransferScene { get; set; }

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
