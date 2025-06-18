namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/mch-transfer/batches/batch-id/{batch_id} 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionMerchantTransferBatchByBatchIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferBatch : GetPlatformSolutionMerchantTransferBatchByOutBatchNumberResponse.Types.TransferBatch
            {
            }

            public class TransferDetail : GetPlatformSolutionMerchantTransferBatchByOutBatchNumberResponse.Types.TransferDetail
            {
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
