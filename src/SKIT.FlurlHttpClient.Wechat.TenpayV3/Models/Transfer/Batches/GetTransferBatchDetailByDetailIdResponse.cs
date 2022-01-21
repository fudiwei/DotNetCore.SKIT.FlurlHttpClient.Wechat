namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口的响应。</para>
    /// </summary>
    public class GetTransferBatchDetailByDetailIdResponse : GetTransferBatchDetailByOutDetailNumberResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;
    }
}
