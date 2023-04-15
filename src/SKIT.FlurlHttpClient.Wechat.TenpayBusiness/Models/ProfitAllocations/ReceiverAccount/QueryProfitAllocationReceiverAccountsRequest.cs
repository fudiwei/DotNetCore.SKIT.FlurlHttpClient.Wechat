namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/receiver-accounts 接口的请求。</para>
    /// </summary>
    public class QueryProfitAllocationReceiverAccountsRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置企业商户 ID。如果不指定将使用构造 <see cref="WechatTenpayBusinessClient"/> 时的 <see cref="WechatTenpayBusinessClientOptions.EnterpriseId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置统一社会信用代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? UnifiedSocialCreditCode { get; set; }
    }
}
