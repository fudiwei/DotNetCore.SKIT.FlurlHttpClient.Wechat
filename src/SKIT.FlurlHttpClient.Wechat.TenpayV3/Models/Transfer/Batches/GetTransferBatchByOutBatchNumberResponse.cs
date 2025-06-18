using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/batches/out-batch-no/{out_batch_no} 接口的响应。</para>
    /// </summary>
    public class GetTransferBatchByOutBatchNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferBatch
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

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
                /// 获取或设置转账场景 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
                public string? TransferSceneId { get; set; }
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
                [Newtonsoft.Json.JsonProperty("detail_status")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_status")]
                public string DetailStatus { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置转账批次单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_batch")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_batch")]
        public Types.TransferBatch TransferBatch { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账明细单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_detail_list")]
        public Types.TransferDetail[]? TransferDetailList { get; set; }
    }
}
