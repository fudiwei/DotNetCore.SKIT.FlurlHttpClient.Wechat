namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transaction-block/transaction-block-records/{block_record_id} 接口的请求。</para>
    /// </summary>
    public class GetTransactionBlockRecordRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易拦截记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BlockRecordId { get; set; } = string.Empty;
    }
}
