using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/mch-transfer/batches/out-batch-no/{out_batch_no} 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionMerchantTransferBatchByOutBatchNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferBatch
            {
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
                public string AppId { get; set; } = default!;

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
                [Newtonsoft.Json.JsonProperty("batch_state")]
                [System.Text.Json.Serialization.JsonPropertyName("batch_state")]
                public string BatchState { get; set; } = default!;

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
                /// 获取或设置转账场景 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
                public string TransferSceneId { get; set; } = default!;

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

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
                [Newtonsoft.Json.JsonProperty("failed_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_amount")]
                public int FailAmount { get; set; }

                /// <summary>
                /// 获取或设置转账失败笔数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_num")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_num")]
                public int FailNumber { get; set; }
            }

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
                public string DetailState { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置转账批次信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_batch")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_batch")]
        public Types.TransferBatch TransferBatch { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账明细单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.TransferDetail[]? TransferDetailList { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }
    }
}
