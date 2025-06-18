namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/batches/batch-id/{batch_id} 接口的响应。</para>
    /// </summary>
    public class GetTransferBatchByBatchIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferBatch : GetTransferBatchByOutBatchNumberResponse.Types.TransferBatch
            {
            }

            public class TransferDetail : GetTransferBatchByOutBatchNumberResponse.Types.TransferDetail
            {
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
