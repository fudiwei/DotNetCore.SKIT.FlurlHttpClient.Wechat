namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transaction-block/transaction-block-submissions/{block_submission_id} 接口的请求。</para>
    /// </summary>
    public class GetTransactionBlockSubmissionRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置交易拦截申诉 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BlockSubmissionId { get; set; } = string.Empty;
    }
}
