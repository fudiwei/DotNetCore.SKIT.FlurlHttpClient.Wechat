namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/{allocation_id} 接口的请求。</para>
    /// </summary>
    public class GetProfitAllocationByAllocationIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AllocationId { get; set; } = string.Empty;
    }
}
