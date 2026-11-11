namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /partner-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口的请求。</para>
    /// </summary>
    public class GetPartnerTransferBatchDetailByDetailIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BatchId { get; set; }

        /// <summary>
        /// 获取或设置微信支付明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? DetailId { get; set; }
    }
}
